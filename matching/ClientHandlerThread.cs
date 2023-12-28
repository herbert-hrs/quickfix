using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System;

namespace QuickFix
{
    // TODO v2.0 - consider changing to internal


    /// <summary>
    /// Created by a ThreadedSocketReactor to handle a client connection.
    /// Each ClientHandlerThread has a SocketReader which reads
    /// from the socket.
    /// </summary>
    public class ClientHandlerThread : IResponder, IDisposable
    {
        internal class ExitedEventArgs : EventArgs
        {
            public ClientHandlerThread ClientHandlerThread { get; private set; }

            public ExitedEventArgs(ClientHandlerThread clientHandlerThread)
            {
                this.ClientHandlerThread = clientHandlerThread;
            }
        }

        internal delegate void ExitedEventHandler(object sender, ClientHandlerThread.ExitedEventArgs e);
        internal event ExitedEventHandler Exited;

        public long Id { get; private set; }

        private SocketReader socketReader_ = null;
        private FileLog log_;


        /// <summary>
        /// Creates a ClientHandlerThread
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="clientId"></param>
        /// <param name="settingsDict"></param>
        /// <param name="socketSettings"></param>
        public ClientHandlerThread(IApplication app,TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict, SocketSettings socketSettings)
            : this(app, tcpClient, clientId, settingsDict, socketSettings, null)
        {
            
        }

        internal ClientHandlerThread(IApplication app, TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict,
            SocketSettings socketSettings, AcceptorSocketDescriptor acceptorDescriptor)
        {
            string debugLogFilePath = "log";
            if (settingsDict.Has(SessionSettings.DEBUG_FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.DEBUG_FILE_LOG_PATH);
            else if (settingsDict.Has(SessionSettings.FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.FILE_LOG_PATH);

            // FIXME - do something more flexible than hardcoding a filelog
            //log_ = new FileLog(debugLogFilePath, new SessionID(
            //        "ClientHandlerThread", clientId.ToString(), "Debug-" + Guid.NewGuid().ToString()));
            log_ = null;

            this.Id = clientId;
            socketReader_ = new SocketReader(app, tcpClient, socketSettings, this, acceptorDescriptor);
            
        }


        public bool CloseCallBack()
        {
            socketReader_.Dispose();
            OnExited();

            return true;
        }

        public void CheckNextMsg()
        {
            if(socketReader_ != null)
                socketReader_.CheckNextMsg();
        }

        public void Start()
        {
            try
            {
                
                socketReader_.CreateStream(CloseCallBack);
                socketReader_.DisableTimeout();

                socketReader_.Read();

            }
            catch (Exception e)
            {
                socketReader_.Dispose();
                Shutdown(e.Message);
                OnExited();
            }
        }

        public void Shutdown(string reason)
        {
            Log("shutdown requested: " + reason);
        }


        protected void OnExited()
        {
            if (Exited != null)
                Exited(this, new ExitedEventArgs(this));
        }

        /// FIXME do real logging
        public void Log(string s)
        {
            log_?.OnEvent(s);
        }

        /// <summary>
        /// Provide StreamReader with access to the log
        /// </summary>
        /// <returns></returns>
        internal ILog GetLog()
        {
            return log_;
        }

        #region Responder Members

        public bool Send(string data)
        {
            socketReader_.Send(data);

            return true;
        }

        public void Disconnect()
        {
            Shutdown("Disconnected");
        }

        #endregion

        ~ClientHandlerThread() => Dispose(false);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                if (socketReader_ != null)
                {
                    socketReader_.Dispose();
                    socketReader_ = null;
                }

                if (log_ != null)
                {
                    log_.Dispose();
                    log_ = null;
                }
            }
            _disposed = true;
        }
    }
}
