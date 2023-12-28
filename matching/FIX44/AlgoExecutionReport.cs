using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class AlgoExecutionReport : Message
        {
            public const string MsgType = "U305";

            public AlgoExecutionReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U305"));
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

            public void Set(QuickFix.Fields.ParentOrderID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.ParentOrderID Get(QuickFix.Fields.ParentOrderID val)
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

            public void Set(QuickFix.Fields.OrderStatus val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.OrderStatus Get(QuickFix.Fields.OrderStatus val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.Quantity val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.Quantity Get(QuickFix.Fields.Quantity val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.CumQty val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.CumQty Get(QuickFix.Fields.CumQty val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.LeavesQty val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.LeavesQty Get(QuickFix.Fields.LeavesQty val)
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
