using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class MarketDataRequest : Message
        {
            public const string MsgType = "V";

            public MarketDataRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("V"));
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
            
            public void Set(QuickFix.Fields.SubscriptionRequestType val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.MarketDepth val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.NoMDEntryTypes val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.NoMDEntryTypes Get(QuickFix.Fields.NoMDEntryTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public void Set(QuickFix.Fields.NoRelatedSym val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.NoRelatedSym Get(QuickFix.Fields.NoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public class NoMDEntryTypesGroup : Group
            {
                public static int[] fieldOrder = {Tags.MDEntryType, 0};
            
                public NoMDEntryTypesGroup(): base( Tags.NoMDEntryTypes, Tags.MDEntryType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMDEntryTypesGroup();
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
            }
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {Tags.Symbol, Tags.SecurityID, Tags.SecurityIDSource, 0};
            
                public NoRelatedSymGroup(): base( Tags.NoRelatedSym, Tags.Symbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                            
                public void Set(QuickFix.Fields.SecurityIDSource val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
            }
        }
    }
}
