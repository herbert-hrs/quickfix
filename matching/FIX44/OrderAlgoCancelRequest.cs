using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class OrderAlgoCancelRequest : Message
        {
            public const string MsgType = "U302";

            public OrderAlgoCancelRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U302"));
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

            public void Set(QuickFix.Fields.NoOrders val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val)
            {
                GetField(val);
                return val;
            }

            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {
                    Tags.ParentOrderID,
                    Tags.ClOrdID,                   
                    Tags.SourceAddress,
                    0
                };

                public NoOrdersGroup() : base(Tags.NoOrders, Tags.ParentOrderID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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

                public void Set(QuickFix.Fields.ClOrdID val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
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
            }
        }
    }
}
