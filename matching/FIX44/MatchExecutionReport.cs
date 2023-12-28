using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class MatchExecutionReport: Message
        {
            public MatchExecutionReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U405"));
            }

            public void Set(QuickFix.Fields.IsAttack val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.IsAttack Get(QuickFix.Fields.IsAttack val)
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

            public void Set(QuickFix.Fields.LogonRejCode val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.LogonRejCode Get(QuickFix.Fields.LogonRejCode val)
            {
                GetField(val);
                return val;
            }
                        
            public void Set(QuickFix.Fields.SPU val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.SPU Get(QuickFix.Fields.SPU val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.SAvgTax val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.SAvgTax Get(QuickFix.Fields.SAvgTax val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.SLastTax val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.SLastTax Get(QuickFix.Fields.SLastTax val)
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

            public void Set(QuickFix.Fields.LastQty val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.LastQty Get(QuickFix.Fields.LastQty val)
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

            public void Set(QuickFix.Fields.Side val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
            {
                GetField(val);
                return val;
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

            public void Set(QuickFix.Fields.OrderID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.TradeDate val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
            {
                GetField(val);
                return val;
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


            public void Set(QuickFix.Fields.UniqueTradeID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.UniqueTradeID Get(QuickFix.Fields.UniqueTradeID val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.SecondaryOrderID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.SLastPU val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.SLastPU Get(QuickFix.Fields.SLastPU val)
            {
                GetField(val);
                return val;
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

            public void Set(QuickFix.Fields.OrigClOrdID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val)
            {
                GetField(val);
                return val;
            }
        }
    }
}