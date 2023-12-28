using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class NetworkStatusReponse: Message
        {
            public NetworkStatusReponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BD"));
            }

            public void Set(QuickFix.Fields.NetworkResponseID val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.NetworkResponseID Get(QuickFix.Fields.NetworkResponseID val)
            {
                GetField(val);
                return val;
            }

            public void Set(QuickFix.Fields.NoCompIDs val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.NoCompIDs Get(QuickFix.Fields.NoCompIDs val)
            {
                GetField(val);
                return val;
            }

            public class NoCompIDGroup : Group
            {
                public static int[] fieldOrder = {
                    Tags.RefCompID,
                    Tags.StatusValue,
                    Tags.StatusText,
                    0
                };

                public NoCompIDGroup() : base(Tags.NoCompIDs, Tags.RefCompID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoCompIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public void Set(QuickFix.Fields.RefCompID val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.RefCompID Get(QuickFix.Fields.RefCompID val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.StatusValue val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.StatusValue Get(QuickFix.Fields.StatusValue val)
                {
                    GetField(val);
                    return val;
                }

                public void Set(QuickFix.Fields.StatusText val)
                {
                    this.SetField(val);
                }

                public QuickFix.Fields.StatusText Get(QuickFix.Fields.StatusText val)
                {
                    GetField(val);
                    return val;
                }                
            }
        }
    }
}