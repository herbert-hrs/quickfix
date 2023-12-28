using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix
{
    public class MessageFactory : IMessageFactory
    {
        public ICollection<string> GetSupportedBeginStrings()
        {
            return new[] { BeginString.FIX44 };
        }


        public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
        {
            return Create(beginString, msgType);
        }


        public QuickFix.Message Create(string beginString, string msgType)
        {
            switch (msgType)
            {
                case QuickFix.FIX44.Heartbeat.MsgType: return new QuickFix.FIX44.Heartbeat();
                case QuickFix.FIX44.Logon.MsgType: return new QuickFix.FIX44.Logon();
                case QuickFix.FIX44.TestRequest.MsgType: return new QuickFix.FIX44.TestRequest();
                case QuickFix.FIX44.ResendRequest.MsgType: return new QuickFix.FIX44.ResendRequest();
                case QuickFix.FIX44.Reject.MsgType: return new QuickFix.FIX44.Reject();
                case QuickFix.FIX44.SequenceReset.MsgType: return new QuickFix.FIX44.SequenceReset();
                case QuickFix.FIX44.Logout.MsgType: return new QuickFix.FIX44.Logout();
                case QuickFix.FIX44.BusinessMessageReject.MsgType: return new QuickFix.FIX44.BusinessMessageReject();
                case QuickFix.FIX44.MarketDataRequest.MsgType: return new QuickFix.FIX44.MarketDataRequest();
                case QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh();
                case QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX44.MarketDataIncrementalRefresh();
                case QuickFix.FIX44.SecurityListRequest.MsgType: return new QuickFix.FIX44.SecurityListRequest();
                case QuickFix.FIX44.SecurityList.MsgType: return new QuickFix.FIX44.SecurityList();
            }

            return new QuickFix.Message();
        }


        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
            if (QuickFix.FIX44.Logon.MsgType.Equals(msgType))
            {
                switch (correspondingFieldID)
                {
                    case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX44.Logon.NoMsgTypesGroup();
                }
            }

            if (QuickFix.FIX44.MarketDataRequest.MsgType.Equals(msgType))
            {
                switch (correspondingFieldID)
                {
                    case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup();
                    case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup();
                }
            }

            if (QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
            {
                switch (correspondingFieldID)
                {
                    case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                }
            }

            if (QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
            {
                switch (correspondingFieldID)
                {
                    case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                }
            }

            if (QuickFix.FIX44.SecurityList.MsgType.Equals(msgType))
            {
                switch (correspondingFieldID)
                {
                    case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup();
                }
            }

            return null;
        }
    }
}
