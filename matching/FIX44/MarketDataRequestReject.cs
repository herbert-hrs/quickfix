using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class MarketDataRequestReject : Message
        {
            public const string MsgType = "Y";

            public MarketDataRequestReject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("Y"));
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

            public void Set(QuickFix.Fields.MDReqRejReason val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.MDReqRejReason Get(QuickFix.Fields.MDReqRejReason val) 
            { 
                GetField(val);
                return val;
            }
            public class NoAltMDSourceGroup : Group
            {
                public static int[] fieldOrder = {Tags.AltMDSourceID, 0};

                public NoAltMDSourceGroup(): base(Tags.NoAltMDSource, Tags.AltMDSourceID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoAltMDSourceGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public void Set(QuickFix.Fields.AltMDSourceID val) 
                {
                    this.SetField(val);
                }
                
                public QuickFix.Fields.AltMDSourceID Get(QuickFix.Fields.AltMDSourceID val) 
                { 
                    GetField(val);
                    return val;
                }

            }

            public void Set(QuickFix.Fields.Text val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.EncodedTextLen val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.EncodedText val) 
            {
                this.SetField(val);
            }
            
            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }

        }
    }
}