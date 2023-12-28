using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class NewOrderAlgoRequest : Message
        {
            public const string MsgType = "U300";

            public NewOrderAlgoRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U300"));
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
                    Tags.ClOrdID,
                    Tags.Symbol,
                    Tags.AccountID,
                    Tags.AccountName,
                    Tags.GroupID,
                    Tags.BrokerID,
                    Tags.BuyQty,
                    Tags.SellQty,
                    Tags.DIVertex,
                    Tags.DeltaNTNB,
                    Tags.CurveNTNB,
                    Tags.ShiftNTNB,
                    Tags.RewardLTN,
                    Tags.SpreadFactor,
                    Tags.SourceAddress,
                    0
                };
            
                public NoOrdersGroup(): base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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

                public void Set(QuickFix.Fields.GroupID val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.GroupID Get(QuickFix.Fields.GroupID val)
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

                public void Set(QuickFix.Fields.BuyQty val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.BuyQty Get(QuickFix.Fields.BuyQty val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.SellQty val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.SellQty Get(QuickFix.Fields.SellQty val)
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
