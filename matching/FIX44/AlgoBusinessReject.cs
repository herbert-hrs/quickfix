using QuickFix.Fields;

namespace QuickFix
{
    namespace FIX44
    {
        public class AlgoBusinessReject : Message
        {
            public const string MsgType = "U303";

            public AlgoBusinessReject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("U303"));
            }

            public void Set(QuickFix.Fields.RefMsgType val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val)
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

            public void Set(QuickFix.Fields.RejectSource val)
            {
                this.SetField(val);
            }

            public QuickFix.Fields.RejectSource Get(QuickFix.Fields.RejectSource val)
            {
                GetField(val);
                return val;
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
