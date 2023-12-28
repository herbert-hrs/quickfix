using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class SecurityQuotes : Message
        {
            public const string MsgType = "SQ";

            public SecurityQuotes() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("SQ"));
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

            public void Set(QuickFix.Fields.MDUpdateAction val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.MDUpdateAction Get(QuickFix.Fields.MDUpdateAction val) 
            { 
                GetField(val);
                return val;
            }
        }
    }
}
