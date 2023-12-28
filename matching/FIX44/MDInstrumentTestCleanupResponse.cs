using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class MDInstrumentTestCleanupResponse : Message
        {
            public const string MsgType = "ITCR";

            public MDInstrumentTestCleanupResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("ITCR"));
            }

            public void Set(QuickFix.Fields.TransactTime val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
        }
    }
}
