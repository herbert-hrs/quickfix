using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class SecurityListQuotes : Message
        {
            public const string MsgType = "SLQ";

            public SecurityListQuotes() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("SLQ"));
            }

            public void Set(QuickFix.Fields.SecurityReqID val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public void Set(QuickFix.Fields.SecurityResponseID val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.SecurityResponseID Get(QuickFix.Fields.SecurityResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public void Set(QuickFix.Fields.TotNoRelatedSym val) 
            {
                this.SetField(val);
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
        
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {Tags.Symbol, Tags.SecurityID, Tags.SecurityIDSource, Tags.RoundLot, 0};
            
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
