using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class MatchInstrumentReload : Message
        {
            public const string MsgType = "IR";

            public MatchInstrumentReload() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("IR"));
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
