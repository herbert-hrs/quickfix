
namespace QuickFix.Fields
{
    public static class Limits
    {       
        public const int FIX44_LAST_FIELD = Tags.LegInterestAccrualDate;
       
        public const int NORMAL_MIN = 1;
        public const int NORMAL_MAX = 4999;
        public const int USER_MIN = 5000;
        public const int USER_MAX = 9999;
        public const int INTERNAL_MIN = 10000;
    }
}
