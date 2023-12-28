using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class TradeHistoryResponse : Message
        {
            public const string MsgType = "UTHP";

            public TradeHistoryResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("UTHP"));
            }

            public void Set(QuickFix.Fields.MDReqID val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public void Set(QuickFix.Fields.NoMDEntries val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.NoMDEntries Get(QuickFix.Fields.NoMDEntries val)
            {
                GetField(val);
                return val;
            }

            public class NoMDEntriesGroup : Group
            {
                public static int[] fieldOrder = {Tags.MDEntryType, Tags.MDEntryPx, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.OrderID, Tags.MDEntryBuyer, Tags.MDEntrySeller, Tags.MDEntryPositionNo, 0};
            
                public NoMDEntriesGroup(): base( Tags.NoMDEntries, Tags.MDEntryType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMDEntriesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
                
                public void Set(QuickFix.Fields.MDEntryType val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.MDEntryType Get(QuickFix.Fields.MDEntryType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public void Set(QuickFix.Fields.MDEntryPx val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.MDEntryPx Get(QuickFix.Fields.MDEntryPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public void Set(QuickFix.Fields.MDEntrySize val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.MDEntrySize Get(QuickFix.Fields.MDEntrySize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public void Set(QuickFix.Fields.MDEntryDate val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.MDEntryDate Get(QuickFix.Fields.MDEntryDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public void Set(QuickFix.Fields.MDEntryTime val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.MDEntryTime Get(QuickFix.Fields.MDEntryTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public void Set(QuickFix.Fields.OrderID val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public void Set(QuickFix.Fields.MDEntryPositionNo val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.MDEntryPositionNo Get(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.UniqueTradeID val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.UniqueTradeID Get(QuickFix.Fields.UniqueTradeID val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.PU val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.PU Get(QuickFix.Fields.PU val)
                {
                    GetField(val);
                    return val;
                }
            }
        }
    }
}
