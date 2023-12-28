using System.Net.Sockets;
using System.IO;
using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Channels;

namespace QuickFix
{
    /// <summary>
    /// TODO merge with SocketInitiatorThread
    /// </summary>
    public class SocketReader : IDisposable
    {
        public const int BUF_SIZE = 4096;
        byte[] readBuffer_ = new byte[BUF_SIZE];
        private Parser parser_ = new Parser();
        private Session qfSession_ = null; //will be null when initialized
        private Stream stream_;     //will be null when initialized
        private TcpClient tcpClient_;
        private IApplication app_;
        private SocketSettings settings_;
        private ClientHandlerThread responder_;
        private readonly AcceptorSocketDescriptor acceptorDescriptor_;
        private object _syncR;
        private object _syncW;

        private Queue<string> _queueW;
        private Func<bool> ClosedCallBack_;

        public SocketReader(IApplication app,TcpClient tcpClient, SocketSettings settings, ClientHandlerThread responder)
            : this(app,tcpClient, settings, responder, null)
        { }

        

        internal SocketReader(
            IApplication app,
            TcpClient tcpClient,
            SocketSettings settings,
            ClientHandlerThread responder,
            AcceptorSocketDescriptor acceptorDescriptor)
        {
            _syncR = new object();
            _syncW = new object();
            _queueW = new Queue<string>();

            app_ = app;
            tcpClient_ = tcpClient;
            responder_ = responder;
            acceptorDescriptor_ = acceptorDescriptor;
            settings_ = settings;
        }

        public void CreateStream(Func<bool> ClosedCallBack)
        {
            ClosedCallBack_ = ClosedCallBack;
            stream_ = Transport.StreamFactory.CreateServerStream(tcpClient_, settings_, responder_.GetLog());
        }

        public void DisableTimeout()
        {
            stream_.ReadTimeout = Timeout.Infinite;
        }

        private void ReadCallBack(IAsyncResult result)
        {
            if (_disposed) return;

            lock(_syncR)
            {
                try
                {
                    int bytes = stream_.EndRead(result);
                    

                    if(bytes == 0)
                    {
                        HandleExceptionInternal(qfSession_, new SocketException(System.Convert.ToInt32(SocketError.ConnectionReset)));
                        ClosedCallBack_();
                    }
                    else
                    {
                        parser_.AddToStream(readBuffer_, bytes);
                        ProcessStream();

                        Read();

                    }
                }
                catch (Exception e)
                {
                    HandleExceptionInternal(qfSession_, e);
                    ClosedCallBack_();
                }

            }
        }

        public void Read()
        {
            if (_disposed) return;

            lock(_syncR)
            {
                try
                {
                    stream_.BeginRead(readBuffer_, 0, readBuffer_.Length, ReadCallBack, null);
                }
                catch (Exception e)
                {
                    HandleExceptionInternal(qfSession_, e);
                    ClosedCallBack_();
                }
            }
        }

        private void OnMessageFound(string msg)
        {
            try
            {
                if (null == qfSession_)
                {
                    if (Fields.MsgType.LOGON.Equals(Message.GetMsgType(msg)))
                    {
                        app_.OnConnect(this, new Message(msg), Message.GetReverseSessionID(msg));
                    }
                    qfSession_ = Session.LookupSession(Message.GetReverseSessionID(msg));
                    if (null == qfSession_)
                    {
                        this.Log("ERROR: Disconnecting; received message for unknown session: " + msg);
                        DisconnectClient();
                        return;
                    }
                    else if(IsAssumedSession(qfSession_.SessionID))
                    {
                        this.Log("ERROR: Disconnecting; received message for unknown session: " + msg);
                        qfSession_ = null;
                        DisconnectClient();
                        return;
                    }
                    else
                    {
                        if (!HandleNewSession(msg))
                            return;
                    }
                }

                try
                {
                    qfSession_.Next(msg);
                }
                catch (System.Exception e)
                {
                    this.Log("Error on Session '" + qfSession_.SessionID + "': " + e.ToString());
                }
            }
            catch (InvalidMessage e)
            {
                HandleBadMessage(msg, e);
            }
            catch (MessageParseError e)
            {
                HandleBadMessage(msg, e);
            }
        }

        protected void HandleBadMessage(string msg, System.Exception e)
        {
            try
            {
                if (Fields.MsgType.LOGON.Equals(Message.GetMsgType(msg)))
                {
                    this.Log("ERROR: Invalid LOGON message, disconnecting: " + e.Message);
                    DisconnectClient();
                }
                else
                {
                    this.Log("ERROR: Invalid message: " + e.Message);
                }
            }
            catch (InvalidMessage)
            { }
        }

        protected bool ReadMessage(out string msg)
        {
            try
            {
                return parser_.ReadFixMessage(out msg);
            }
            catch (MessageParseError e)
            {
                msg = "";
                throw e;
            }
        }
        public void CheckNextMsg()
        {
            if(qfSession_ != null)
                qfSession_.Next();
        }

        protected void ProcessStream()
        {
            string msg;
            while (ReadMessage(out msg))
            {
                OnMessageFound(msg);
            }
        }

        protected void DisconnectClient()
        {
            if (_disposed) return;

            stream_.Close();
            tcpClient_.Close();
            
        }

        protected bool HandleNewSession(string msg)
        {
            if (qfSession_.HasResponder)
            {
                qfSession_.Log.OnIncoming(msg);
                qfSession_.Log.OnEvent("Multiple logons/connections for this session are not allowed (" + tcpClient_.Client.RemoteEndPoint + ")");
                qfSession_ = null;
                DisconnectClient();
                return false;
            }
            qfSession_.Log.OnEvent(qfSession_.SessionID + " Socket Reader " + GetHashCode() + " accepting session " + qfSession_.SessionID + " from " + tcpClient_.Client.RemoteEndPoint);
            // FIXME do this here? qfSession_.HeartBtInt = QuickFix.Fields.Converters.IntConverter.Convert(message.GetField(Fields.Tags.HeartBtInt)); /// FIXME
            qfSession_.Log.OnEvent(qfSession_.SessionID + " Acceptor heartbeat set to " + qfSession_.HeartBtInt + " seconds");
            qfSession_.SetResponder(responder_);
            return true;
        }

        private void HandleException(Session quickFixSession, System.Exception cause, TcpClient client)
        {
            HandleExceptionInternal(quickFixSession, cause);
        }

        private bool IsAssumedSession(SessionID sessionID)
        {
            return acceptorDescriptor_ != null 
                   && !acceptorDescriptor_.GetAcceptedSessions().Any(kv => kv.Key.Equals(sessionID));
        }

        private void HandleExceptionInternal(Session quickFixSession, System.Exception cause)
        {
            bool disconnectNeeded = true;
            string reason = cause.Message;

            System.Exception realCause = cause;

            // Unwrap socket exceptions from IOException in order for code below to work
            if (realCause is IOException && realCause.InnerException is SocketException)
                realCause = realCause.InnerException;

            /*
             TODO
            if(cause is FIXMessageDecoder.DecodeError && cause.InnerException != null)
                realCause = cause.getCause();
            */
            if (realCause is System.Net.Sockets.SocketException)
            {
                if (quickFixSession != null && quickFixSession.IsEnabled)
                    reason = "Socket exception (" + tcpClient_.Client.RemoteEndPoint + "): " + cause.Message;
                else
                    reason = "Socket (" + tcpClient_.Client.RemoteEndPoint + "): " + cause.Message;
                disconnectNeeded = true;
            }
            /*
             TODO
            else if(realCause is FIXMessageDecoder.CriticalDecodeError)
            {
                reason = "Critical protocol codec error: " + cause;
                disconnectNeeded = true;
            }
            */
            else if (realCause is MessageParseError)
            {
                reason = "Protocol handler exception: " + cause;
                if (quickFixSession == null)
                    disconnectNeeded = true;
                else
                    disconnectNeeded = false;
            }
            else
            {
                reason = cause.ToString();
                disconnectNeeded = false;
            }

            this.Log("SocketReader Error: " + reason);

            if (disconnectNeeded)
            {
                if (null != quickFixSession && quickFixSession.HasResponder)
                    quickFixSession.Disconnect(reason);
                else
                    DisconnectClient();

            }
        }

        /// <summary>
        /// FIXME do proper logging
        /// </summary>
        /// <param name="s"></param>
        private void Log(string s)
        {
            responder_.Log(s);
        }

        private void SendCallBack(IAsyncResult result)
        {
            if (_disposed) return;

            lock(_syncW)
            {
                stream_.EndWrite(result);
                SendData();

            }
        }

        private void SendData()
        {
            if (_disposed) return;

            lock(_syncW)
            {
                if(_queueW.Count > 0)
                {
                    byte[] rawData = CharEncoding.DefaultEncoding.GetBytes(_queueW.Dequeue());
                            
                    stream_.BeginWrite(rawData, 0, rawData.Length, SendCallBack, null);
                }
            }
        }

        public void Send(string data)
        {
            lock(_syncW)
            {
                _queueW.Enqueue(data);
                if(_queueW.Count == 1)
                    SendData();   
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                lock(_syncW)
                {
                    _queueW.Clear();
                }

                stream_?.Dispose();
                tcpClient_?.Close();

                _disposed = true;
            }
        }
        ~SocketReader() => Dispose(false);
    }
}
