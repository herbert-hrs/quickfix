using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class OrderAlgoReplaceRequest : Message
        {
            public const string MsgType = "U301";

            public OrderAlgoReplaceRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U301"));
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
                    Tags.DIVertex,
                    Tags.DeltaNTNB,
                    Tags.CurveNTNB,
                    Tags.ShiftNTNB,
                    Tags.RewardLTN,
                    Tags.SpreadFactor,
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

                public void Set(QuickFix.Fields.DIVertex val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.DIVertex Get(QuickFix.Fields.DIVertex val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.DeltaNTNB val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.DeltaNTNB Get(QuickFix.Fields.DeltaNTNB val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.CurveNTNB val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.CurveNTNB Get(QuickFix.Fields.CurveNTNB val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.ShiftNTNB val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.ShiftNTNB Get(QuickFix.Fields.ShiftNTNB val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.RewardLTN val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.RewardLTN Get(QuickFix.Fields.RewardLTN val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.SpreadFactor val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.SpreadFactor Get(QuickFix.Fields.SpreadFactor val)
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
