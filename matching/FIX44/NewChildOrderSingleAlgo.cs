using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class NewChildOrderSingleAlgo : Message
        {
            public const string MsgType = "U306";

            public NewChildOrderSingleAlgo() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U306"));
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

            public void Set(QuickFix.Fields.Symbol val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
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

            public void Set(QuickFix.Fields.AccountID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.AccountID Get(QuickFix.Fields.AccountID val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.AccountName val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.AccountName Get(QuickFix.Fields.AccountName val)
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

            public void Set(QuickFix.Fields.STax val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.STax Get(QuickFix.Fields.STax val)
            {
                GetField(val);
                return val;
            }           

            public void Set(QuickFix.Fields.BrokerID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.BrokerID Get(QuickFix.Fields.BrokerID val)
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

            public void Set(QuickFix.Fields.ParentOrderID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.ParentOrderID Get(QuickFix.Fields.ParentOrderID val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.GroupID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.GroupID Get(QuickFix.Fields.GroupID val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.MemoID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.MemoID Get(QuickFix.Fields.MemoID val)
            {
                GetField(val);
                return val;
            }
        }
    }
}
