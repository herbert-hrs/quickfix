using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class SecurityListRequest : Message
        {
            public const string MsgType = "x";

            public SecurityListRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("x"));
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

            public void Set(QuickFix.Fields.SecurityListRequestType val) 
            {
                this.SetField(val);
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
        }
    }
}
