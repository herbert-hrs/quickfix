using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class OrderChildReplaceAlgo : Message
        {
            public const string MsgType = "U307";

            public OrderChildReplaceAlgo() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U307"));
            }

            public void Set(QuickFix.Fields.ClOrdID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
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
            
            public void Set(QuickFix.Fields.STax val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.STax Get(QuickFix.Fields.STax val)
            {
                GetField(val);
                return val;
            }
            

            public void Set(QuickFix.Fields.SourceAddress val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.SourceAddress Get(QuickFix.Fields.SourceAddress val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.UserEntering val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.UserEntering Get(QuickFix.Fields.UserEntering val)
            {
                GetField(val);
                return val;
            }
        }
    }
}
