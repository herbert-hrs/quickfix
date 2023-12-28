using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class SecurityList : Message
        {
            public const string MsgType = "y";

            public SecurityList() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("y"));
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
            
            public void Set(QuickFix.Fields.SecurityRequestResult val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.SecurityRequestResult Get(QuickFix.Fields.SecurityRequestResult val) 
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
                public static int[] fieldOrder = {Tags.Symbol, Tags.SecurityID, Tags.SecurityIDSource, Tags.SecurityType, Tags.RoundLot, 0};
            
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

                public void Set(QuickFix.Fields.SecurityType val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.RoundLot val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.RoundLot Get(QuickFix.Fields.RoundLot val) 
                { 
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.LastFragment val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
                { 
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.HasOffer val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.HasOffer Get(QuickFix.Fields.HasOffer val) 
                { 
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.IsTest val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.IsTest Get(QuickFix.Fields.IsTest val) 
                { 
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.SecurityValidityTimestamp val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.SecurityValidityTimestamp Get(QuickFix.Fields.SecurityValidityTimestamp val) 
                { 
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.SecurityGroup val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val) 
                { 
                    GetField(val);
                    return val;
                }
            }
        }
    }
}
