using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class SecurityListQuotesRequest : Message
        {
            public const string MsgType = "SLQR";

            public SecurityListQuotesRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("SLQR"));
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
        }
    }
}
