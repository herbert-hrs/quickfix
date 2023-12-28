using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44 
    {
        public class RiskNewOrderResponse : Message
        {
            public const string MsgType = "U408";

            public RiskNewOrderResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U408"));
            }

            public void Set(QuickFix.Fields.MDReqID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val)
            {
                GetField(val);
                return val;
            }


            public void Set(QuickFix.Fields.NoMDEntries val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.NoMDEntries Get(QuickFix.Fields.NoMDEntries val) 
            { 
                GetField(val);
                return val;
            }
            public class NoMDEntriesGroup : Group
            {
                public static int[] fieldOrder = {Tags.Symbol, 0};
            
                public NoMDEntriesGroup(): base(Tags.NoMDEntries, Tags.Symbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMDEntriesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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

                public void Set(QuickFix.Fields.LiquidationType val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.LiquidationType Get(QuickFix.Fields.LiquidationType val) 
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
                                
                public void Set(QuickFix.Fields.SPU val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.SPU Get(QuickFix.Fields.SPU val) 
                { 
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.RiskStatus val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.RiskStatus Get(QuickFix.Fields.RiskStatus val) 
                { 
                    GetField(val);
                    return val;
                }

            }
        }
    }
}