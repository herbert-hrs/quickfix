using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class MDInstrumentTestCleanup : Message
        {
            public const string MsgType = "ITC";

            public MDInstrumentTestCleanup() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("ITC"));
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
