using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// BeginSeqNo Field
    /// </summary>/
    public sealed class BeginSeqNo : IntField
    {
        public const int TAG = 7;

        public BeginSeqNo()
            : base(Tags.BeginSeqNo) { }
        public BeginSeqNo(int val)
            : base(Tags.BeginSeqNo, val) { }

    }

    /// <summary>
    /// BeginString Field
    /// </summary>/
    public sealed class BeginString : StringField
    {
        public const int TAG = 8;

        public BeginString()
            : base(Tags.BeginString) { }
        public BeginString(string val)
            : base(Tags.BeginString, val) { }

    }

    /// <summary>
    /// BodyLength Field
    /// </summary>/
    public sealed class BodyLength : IntField
    {
        public const int TAG = 9;

        public BodyLength()
            : base(Tags.BodyLength) { }
        public BodyLength(int val)
            : base(Tags.BodyLength, val) { }

    }

    /// <summary>
    /// CheckSum Field
    /// </summary>/
    public sealed class CheckSum : StringField
    {
        public const int TAG = 10;

        public CheckSum()
            : base(Tags.CheckSum) { }
        public CheckSum(string val)
            : base(Tags.CheckSum, val) { }

    }

    /// <summary>
    /// ClOrdID Field
    /// </summary>/
    public sealed class ClOrdID : StringField
    {
        public const int TAG = 11;

        public ClOrdID()
            : base(Tags.ClOrdID) { }
        public ClOrdID(string val)
            : base(Tags.ClOrdID, val) { }

    }

    /// <summary>
    /// CumQty Field
    /// </summary>/
    public sealed class CumQty : DecimalField
    {
        public const int TAG = 14;

        public CumQty()
            : base(Tags.CumQty) { }
        public CumQty(Decimal val)
            : base(Tags.CumQty, val) { }

    }

    /// <summary>
    /// EndSeqNo Field
    /// </summary>/
    public sealed class EndSeqNo : IntField
    {
        public const int TAG = 16;

        public EndSeqNo()
            : base(Tags.EndSeqNo) { }
        public EndSeqNo(int val)
            : base(Tags.EndSeqNo, val) { }

    }

    /// <summary>
    /// ExecID Field
    /// </summary>/
    public sealed class ExecID : StringField
    {
        public const int TAG = 17;

        public ExecID()
            : base(Tags.ExecID) { }
        public ExecID(string val)
            : base(Tags.ExecID, val) { }

    }

    /// <summary>
    /// MsgSeqNum Field
    /// </summary>/
    public sealed class MsgSeqNum : IntField
    {
        public const int TAG = 34;

        public MsgSeqNum()
            : base(Tags.MsgSeqNum) { }
        public MsgSeqNum(int val)
            : base(Tags.MsgSeqNum, val) { }

    }

    /// <summary>
    /// MsgType Field
    /// </summary>/
    public sealed class MsgType : StringField
    {
        public const int TAG = 35;

        public MsgType()
            : base(Tags.MsgType) { }
        public MsgType(string val)
            : base(Tags.MsgType, val) { }


        // Field Enumerations
        public const string NEW_ORDER_ALGO_REQUEST = "U300";
        public const string ORDER_ALGO_REPLACE_REQUEST = "U301";
        public const string ORDER_ALGO_CANCEL_REQUEST = "U302";
        public const string ALGO_BUSINESS_REJECT = "U303";
        public const string ALGO_EXECUTION_REPORT = "U305";
        public const string NEW_CHILD_ORDER_SINGLE_ALGO = "U306";
        public const string ORDER_CHILD_REPLACE_ALGO = "U307";
        public const string ORDER_CHILD_CANCEL_ALGO = "U308";
        public const string MATCH_NEW_ORDER_SINGLE = "U400";
        public const string MATCH_NEW_ORDER_CROSS = "U401";
        public const string MATCH_ORDER_REPLACE_REQUEST = "U402";
        public const string MATCH_ORDER_CANCEL_REQUEST = "U403";
        public const string MATCH_TRADE_CANCEL_REQUEST = "U404";
        public const string MATCH_EXECUTION_REPORT = "U405";
        public const string MATCH_TRADE_UPDATE_REQUEST = "U406";
        public const string RISK_NEW_ORDER_REQUEST = "U407";
        public const string RISK_NEW_ORDER_RESPONSE = "U408";
        public const string MARKET_DATA_INSTRUMENT_TEST_CLEANUP = "ITC";
        public const string MARKET_DATA_INSTRUMENT_TEST_CLEANUP_RESPONSE = "ITCR";
        public const string MATCH_INSTRUMENT_RELOAD = "IR";
        public const string MARKET_DATA_REQUEST_REJECT = "Y";
        public const string MARKET_DATA_INCREMENTAL_REFRESH = "X";
        public const string MARKET_DATA_SNAPSHOT_FULL_REFRESH = "W";
        public const string MARKET_DATA_REQUEST = "V";
        public const string BUSINESS_MESSAGE_REJECT = "j";
        public const string SECURITY_LIST_REQUEST = "x";
        public const string NETWORK_STATUS_RESPONSE = "BD";
        public const string NETWORK_STATUS_REQUEST = "BC";
        public const string LOGON = "A";
        public const string LOGOUT = "5";
        public const string SEQUENCE_RESET = "4";
        public const string REJECT = "3";
        public const string RESEND_REQUEST = "2";
        public const string TEST_REQUEST = "1";
        public const string HEARTBEAT = "0";
        public const string SECURITY_LIST = "y";
        public const string SECURITY_STATUS = "f";
        public const string TRADE_HISTORY_REQUEST = "UTHQ";
        public const string TRADE_HISTORY_RESPONSE = "UTHP";
        public const string SECURITY_LIST_QUOTES_REQUEST = "SLQR";
        public const string SECURITY_LIST_QUOTES = "SLQ";
        public const string SECURITY_QUOTES = "SQ";

    }

    /// <summary>
    /// NewSeqNo Field
    /// </summary>/
    public sealed class NewSeqNo : IntField
    {
        public const int TAG = 36;

        public NewSeqNo()
            : base(Tags.NewSeqNo) { }
        public NewSeqNo(int val)
            : base(Tags.NewSeqNo, val) { }

    }

    /// <summary>
    /// OrderID Field
    /// </summary>/
    public sealed class OrderID : StringField
    {
        public const int TAG = 37;

        public OrderID()
            : base(Tags.OrderID) { }
        public OrderID(string val)
            : base(Tags.OrderID, val) { }

    }

    /// <summary>
    /// PossDupFlag Field
    /// </summary>/
    public sealed class PossDupFlag : BooleanField
    {
        public const int TAG = 43;

        public PossDupFlag()
            : base(Tags.PossDupFlag) { }
        public PossDupFlag(Boolean val)
            : base(Tags.PossDupFlag, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean POSSIBLE_DUPLICATE = true;
        public const Boolean ORIGINAL_TRANSMISSION = false;
    }

    /// <summary>
    /// RefSeqNum Field
    /// </summary>/
    public sealed class RefSeqNum : IntField
    {
        public const int TAG = 45;

        public RefSeqNum()
            : base(Tags.RefSeqNum) { }
        public RefSeqNum(int val)
            : base(Tags.RefSeqNum, val) { }

    }

    /// <summary>
    /// SecurityID Field
    /// </summary>/
    public sealed class SecurityID : StringField
    {
        public const int TAG = 48;

        public SecurityID()
            : base(Tags.SecurityID) { }
        public SecurityID(string val)
            : base(Tags.SecurityID, val) { }

    }

    /// <summary>
    /// SenderCompID Field
    /// </summary>/
    public sealed class SenderCompID : StringField
    {
        public const int TAG = 49;

        public SenderCompID()
            : base(Tags.SenderCompID) { }
        public SenderCompID(string val)
            : base(Tags.SenderCompID, val) { }

    }

    /// <summary>
    /// SenderSubID Field
    /// </summary>/
    public sealed class SenderSubID : StringField
    {
        public const int TAG = 50;

        public SenderSubID()
            : base(Tags.SenderSubID) { }
        public SenderSubID(string val)
            : base(Tags.SenderSubID, val) { }

    }

    /// <summary>
    /// SendingTime Field
    /// </summary>/
    public sealed class SendingTime : DateTimeField
    {
        public const int TAG = 52;

        public SendingTime()
            : base(Tags.SendingTime) { }
        public SendingTime(DateTime val)
            : base(Tags.SendingTime, val) { }
        public SendingTime(DateTime val, bool showMilliseconds)
            : base(Tags.SendingTime, val, showMilliseconds) { }
        public SendingTime(DateTime val, Converters.TimeStampPrecision precision)
            : base(Tags.SendingTime, val, precision) { }

    }

    /// <summary>
    /// Side Field
    /// </summary>/
    public sealed class Side : CharField
    {
        public const int TAG = 54;

        public Side()
            : base(Tags.Side) { }
        public Side(char val)
            : base(Tags.Side, val) { }


        // Field Enumerations
        public const char BUY = '1';
        public const char SELL = '2';
        public const char BUY_MINUS = '3';
        public const char SELL_PLUS = '4';
        public const char SELL_SHORT = '5';
        public const char SELL_SHORT_EXEMPT = '6';
        public const char UNDISCLOSED = '7';
        public const char CROSS = '8';
        public const char CROSS_SHORT = '9';
        public const char CROSS_SHORT_EXEMPT = 'A';
        public const char AS_DEFINED = 'B';
        public const char OPPOSITE = 'C';
        public const char SUBSCRIBE = 'D';
        public const char REDEEM = 'E';
        public const char LEND = 'F';
        public const char BORROW = 'G';
        public const char CROSS_SHORT_EXXMPT = 'A';
        public const char D = '7';
    }

    /// <summary>
    /// Symbol Field
    /// </summary>/
    public sealed class Symbol : StringField
    {
        public const int TAG = 55;

        public Symbol()
            : base(Tags.Symbol) { }
        public Symbol(string val)
            : base(Tags.Symbol, val) { }

    }

    /// <summary>
    /// TargetCompID Field
    /// </summary>/
    public sealed class TargetCompID : StringField
    {
        public const int TAG = 56;

        public TargetCompID()
            : base(Tags.TargetCompID) { }
        public TargetCompID(string val)
            : base(Tags.TargetCompID, val) { }

    }

    /// <summary>
    /// TargetSubID Field
    /// </summary>/
    public sealed class TargetSubID : StringField
    {
        public const int TAG = 57;

        public TargetSubID()
            : base(Tags.TargetSubID) { }
        public TargetSubID(string val)
            : base(Tags.TargetSubID, val) { }

    }

    /// <summary>
    /// Text Field
    /// </summary>/
    public sealed class Text : StringField
    {
        public const int TAG = 58;

        public Text()
            : base(Tags.Text) { }
        public Text(string val)
            : base(Tags.Text, val) { }

    }

    /// <summary>
    /// TransactTime Field
    /// </summary>/
    public sealed class TransactTime : DateTimeField
    {
        public const int TAG = 60;

        public TransactTime()
            : base(Tags.TransactTime) { }
        public TransactTime(DateTime val)
            : base(Tags.TransactTime, val) { }
        public TransactTime(DateTime val, bool showMilliseconds)
            : base(Tags.TransactTime, val, showMilliseconds) { }
        public TransactTime(DateTime val, Converters.TimeStampPrecision precision)
            : base(Tags.TransactTime, val, precision) { }

    }

    /// <summary>
    /// NoOrders Field
    /// </summary>/
    public sealed class NoOrders : IntField
    {
        public const int TAG = 73;

        public NoOrders()
            : base(Tags.NoOrders) { }
        public NoOrders(int val)
            : base(Tags.NoOrders, val) { }

    }

    /// <summary>
    /// TradeDate Field
    /// </summary>/
    public sealed class TradeDate : StringField
    {
        public const int TAG = 75;

        public TradeDate()
            : base(Tags.TradeDate) { }
        public TradeDate(string val)
            : base(Tags.TradeDate, val) { }

    }

    /// <summary>
    /// Signature Field
    /// </summary>/
    public sealed class Signature : StringField
    {
        public const int TAG = 89;

        public Signature()
            : base(Tags.Signature) { }
        public Signature(string val)
            : base(Tags.Signature, val) { }

    }

    /// <summary>
    /// SignatureLength Field
    /// </summary>/
    public sealed class SignatureLength : IntField
    {
        public const int TAG = 93;

        public SignatureLength()
            : base(Tags.SignatureLength) { }
        public SignatureLength(int val)
            : base(Tags.SignatureLength, val) { }

    }

    /// <summary>
    /// RawDataLength Field
    /// </summary>/
    public sealed class RawDataLength : IntField
    {
        public const int TAG = 95;

        public RawDataLength()
            : base(Tags.RawDataLength) { }
        public RawDataLength(int val)
            : base(Tags.RawDataLength, val) { }

    }


    /// <summary>
    /// RawData Field
    /// </summary>/
    public sealed class RawData : StringField
    {
        public const int TAG = 96;

        public RawData()
            : base(Tags.RawData) { }
        public RawData(string val)
            : base(Tags.RawData, val) { }

    }


    /// <summary>
    /// PossResend Field
    /// </summary>/
    public sealed class PossResend : BooleanField
    {
        public const int TAG = 97;

        public PossResend()
            : base(Tags.PossResend) { }
        public PossResend(Boolean val)
            : base(Tags.PossResend, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// EncryptMethod Field
    /// </summary>/
    public sealed class EncryptMethod : IntField
    {
        public const int TAG = 98;

        public EncryptMethod()
            : base(Tags.EncryptMethod) { }
        public EncryptMethod(int val)
            : base(Tags.EncryptMethod, val) { }


        // Field Enumerations
        public const int NONE = 0;
        public const int PKCS_1 = 1;
        public const int DES = 2;
        public const int PKCS_3 = 3;
        public const int PGP_4 = 4;
        public const int PGP_5 = 5;
        public const int PEM = 6;
        public const int NONE_OTHER = 0;
        public const int PKCS = 1;
        public const int PKCS_DES = 3;
        public const int PGP_DES = 4;
        public const int PGP_DES_MD5 = 5;
        public const int PEM_DES_MD5 = 6;
        public const int PKCS_PROPRIETARY = 1;
        public const int PKCSDES = 3;
        public const int PGPDES = 4;
        public const int PGPDESMD5 = 5;
        public const int PEMDESMD5 = 6;
    }

    /// <summary>
    /// HeartBtInt Field
    /// </summary>/
    public sealed class HeartBtInt : IntField
    {
        public const int TAG = 108;

        public HeartBtInt()
            : base(Tags.HeartBtInt) { }
        public HeartBtInt(int val)
            : base(Tags.HeartBtInt, val) { }

    }

    /// <summary>
    /// TestReqID Field
    /// </summary>/
    public sealed class TestReqID : StringField
    {
        public const int TAG = 112;

        public TestReqID()
            : base(Tags.TestReqID) { }
        public TestReqID(string val)
            : base(Tags.TestReqID, val) { }

    }

    /// <summary>
    /// OnBehalfOfCompID Field
    /// </summary>/
    public sealed class OnBehalfOfCompID : StringField
    {
        public const int TAG = 115;

        public OnBehalfOfCompID()
            : base(Tags.OnBehalfOfCompID) { }
        public OnBehalfOfCompID(string val)
            : base(Tags.OnBehalfOfCompID, val) { }

    }


    /// <summary>
    /// OnBehalfOfSubID Field
    /// </summary>/
    public sealed class OnBehalfOfSubID : StringField
    {
        public const int TAG = 116;

        public OnBehalfOfSubID()
            : base(Tags.OnBehalfOfSubID) { }
        public OnBehalfOfSubID(string val)
            : base(Tags.OnBehalfOfSubID, val) { }

    }

    /// <summary>
    /// OrigSendingTime Field
    /// </summary>/
    public sealed class OrigSendingTime : DateTimeField
    {
        public const int TAG = 122;

        public OrigSendingTime()
            : base(Tags.OrigSendingTime) { }
        public OrigSendingTime(DateTime val)
            : base(Tags.OrigSendingTime, val) { }
        public OrigSendingTime(DateTime val, bool showMilliseconds)
            : base(Tags.OrigSendingTime, val, showMilliseconds) { }
        public OrigSendingTime(DateTime val, Converters.TimeStampPrecision precision)
            : base(Tags.OrigSendingTime, val, precision) { }

    }

    

    /// <summary>
    /// GapFillFlag Field
    /// </summary>/
    public sealed class GapFillFlag : BooleanField
    {
        public const int TAG = 123;

        public GapFillFlag()
            : base(Tags.GapFillFlag) { }
        public GapFillFlag(Boolean val)
            : base(Tags.GapFillFlag, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean GAP_FILL_MESSAGE_MSGSEQNUM_FIELD_VALID = true;
        public const Boolean SEQUENCE_RESET_IGNORE_MSGSEQNUM = false;
    }

    /// <summary>
    /// DeliverToCompID Field
    /// </summary>/
    public sealed class DeliverToCompID : StringField
    {
        public const int TAG = 128;

        public DeliverToCompID()
            : base(Tags.DeliverToCompID) { }
        public DeliverToCompID(string val)
            : base(Tags.DeliverToCompID, val) { }

    }

    /// <summary>
    /// DeliverToSubID Field
    /// </summary>/
    public sealed class DeliverToSubID : StringField
    {
        public const int TAG = 129;

        public DeliverToSubID()
            : base(Tags.DeliverToSubID) { }
        public DeliverToSubID(string val)
            : base(Tags.DeliverToSubID, val) { }

    }

    /// <summary>
    /// ResetSeqNumFlag Field
    /// </summary>/
    public sealed class ResetSeqNumFlag : BooleanField
    {
        public const int TAG = 141;

        public ResetSeqNumFlag()
            : base(Tags.ResetSeqNumFlag) { }
        public ResetSeqNumFlag(Boolean val)
            : base(Tags.ResetSeqNumFlag, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean YES_RESET_SEQUENCE_NUMBERS = true;
    }

    /// <summary>
    /// SenderLocationID Field
    /// </summary>/
    public sealed class SenderLocationID : StringField
    {
        public const int TAG = 142;

        public SenderLocationID()
            : base(Tags.SenderLocationID) { }
        public SenderLocationID(string val)
            : base(Tags.SenderLocationID, val) { }

    }

    /// <summary>
    /// TargetLocationID Field
    /// </summary>/
    public sealed class TargetLocationID : StringField
    {
        public const int TAG = 143;

        public TargetLocationID()
            : base(Tags.TargetLocationID) { }
        public TargetLocationID(string val)
            : base(Tags.TargetLocationID, val) { }

    }

    /// <summary>
    /// OnBehalfOfLocationID Field
    /// </summary>/
    public sealed class OnBehalfOfLocationID : StringField
    {
        public const int TAG = 144;

        public OnBehalfOfLocationID()
            : base(Tags.OnBehalfOfLocationID) { }
        public OnBehalfOfLocationID(string val)
            : base(Tags.OnBehalfOfLocationID, val) { }

    }

    /// <summary>
    /// DeliverToLocationID Field
    /// </summary>/
    public sealed class DeliverToLocationID : StringField
    {
        public const int TAG = 145;

        public DeliverToLocationID()
            : base(Tags.DeliverToLocationID) { }
        public DeliverToLocationID(string val)
            : base(Tags.DeliverToLocationID, val) { }

    }

    /// <summary>
    /// NoRelatedSym Field
    /// </summary>/
    public sealed class NoRelatedSym : IntField
    {
        public const int TAG = 146;

        public NoRelatedSym()
            : base(Tags.NoRelatedSym) { }
        public NoRelatedSym(int val)
            : base(Tags.NoRelatedSym, val) { }

    }

    /// <summary>
    /// SecurityType Field
    /// </summary>/
    public sealed class SecurityType : StringField
    {
        public const int TAG = 167;

        public SecurityType()
            : base(Tags.SecurityType) { }
        public SecurityType(string val)
            : base(Tags.SecurityType, val) { }

        // Field Enumerations
        public const string RF = "RF";
        public const string FUT = "FUT";
    }

    /// <summary>
    /// LeavesQty Field
    /// </summary>/
    public sealed class LeavesQty : DecimalField
    {
        public const int TAG = 151;

        public LeavesQty()
            : base(Tags.LeavesQty) { }
        public LeavesQty(Decimal val)
            : base(Tags.LeavesQty, val) { }

    }

    /// <summary>
    /// MDReqID Field
    /// </summary>/
    public sealed class MDReqID : StringField
    {
        public const int TAG = 262;

        public MDReqID()
            : base(Tags.MDReqID) { }
        public MDReqID(string val)
            : base(Tags.MDReqID, val) { }

    }

    /// <summary>
    /// SubscriptionRequestType Field
    /// </summary>/
    public sealed class SubscriptionRequestType : CharField
    {
        public const int TAG = 263;

        public SubscriptionRequestType()
            : base(Tags.SubscriptionRequestType) { }
        public SubscriptionRequestType(char val)
            : base(Tags.SubscriptionRequestType, val) { }


        // Field Enumerations
        public const char SNAPSHOT = '0';
        public const char SNAPSHOT_PLUS_UPDATES = '1';
        public const char DISABLE_PREVIOUS_SNAPSHOT_PLUS_UPDATE_REQUEST = '2';
        public const char DISABLE_PREVIOUS = '2';
    }

    /// <summary>
    /// MarketDepth Field
    /// </summary>/
    public sealed class MarketDepth : IntField
    {
        public const int TAG = 264;

        public MarketDepth()
            : base(Tags.MarketDepth) { }
        public MarketDepth(int val)
            : base(Tags.MarketDepth, val) { }

    }

    /// <summary>
    /// MDUpdateType Field
    /// </summary>/
    public sealed class MDUpdateType : IntField
    {
        public const int TAG = 265;

        public MDUpdateType()
            : base(Tags.MDUpdateType) { }
        public MDUpdateType(int val)
            : base(Tags.MDUpdateType, val) { }


        // Field Enumerations
        public const int FULL_REFRESH = 0;
        public const int INCREMENTAL_REFRESH = 1;
    }

    /// <summary>
    /// NoMDEntryTypes Field
    /// </summary>/
    public sealed class NoMDEntryTypes : IntField
    {
        public const int TAG = 267;

        public NoMDEntryTypes()
            : base(Tags.NoMDEntryTypes) { }
        public NoMDEntryTypes(int val)
            : base(Tags.NoMDEntryTypes, val) { }

    }

    /// <summary>
    /// NoMDEntries Field
    /// </summary>/
    public sealed class NoMDEntries : IntField
    {
        public const int TAG = 268;

        public NoMDEntries()
            : base(Tags.NoMDEntries) { }
        public NoMDEntries(int val)
            : base(Tags.NoMDEntries, val) { }

    }

    /// <summary>
    /// MDEntryType Field
    /// </summary>/
    public sealed class MDEntryType : CharField
    {
        public const int TAG = 269;

        public MDEntryType()
            : base(Tags.MDEntryType) { }
        public MDEntryType(char val)
            : base(Tags.MDEntryType, val) { }


        // Field Enumerations
        public const char BID = '0';
        public const char OFFER = '1';
        public const char TRADE = '2';
        public const char INDEX_VALUE = '3';
        public const char OPENING_PRICE = '4';
        public const char CLOSING_PRICE = '5';
        public const char SETTLEMENT_PRICE = '6';
        public const char TRADING_SESSION_HIGH_PRICE = '7';
        public const char TRADING_SESSION_LOW_PRICE = '8';
        public const char TRADING_SESSION_VWAP_PRICE = '9';
        public const char IMBALANCE = 'A';
        public const char TRADE_VOLUME = 'B';
        public const char OPEN_INTEREST = 'C';
        public const char COMPOSITE_UNDERLYING_PRICE = 'D';
        public const char SIMULATED_SELL_PRICE = 'E';
        public const char SIMULATED_BUY_PRICE = 'F';
        public const char MARGIN_RATE = 'G';
        public const char MID_PRICE = 'H';
        public const char EMPTY_BOOK = 'J';
        public const char SETTLE_HIGH_PRICE = 'K';
        public const char SETTLE_LOW_PRICE = 'L';
        public const char PRIOR_SETTLE_PRICE = 'M';
        public const char SESSION_HIGH_BID = 'N';
        public const char SESSION_LOW_OFFER = 'O';
        public const char EARLY_PRICES = 'P';
        public const char AUCTION_CLEARING_PRICE = 'Q';
        public const char SWAP_VALUE_FACTOR = 'S';
        public const char DAILY_VALUE_ADJUSTMENT_FOR_LONG_POSITIONS = 'R';
        public const char CUMULATIVE_VALUE_ADJUSTMENT_FOR_LONG_POSITIONS = 'T';
        public const char DAILY_VALUE_ADJUSTMENT_FOR_SHORT_POSITIONS = 'U';
        public const char CUMULATIVE_VALUE_ADJUSTMENT_FOR_SHORT_POSITIONS = 'V';
        public const char RECOVERY_RATE = 'Y';
        public const char RECOVERY_RATE_FOR_LONG = 'Z';
        public const char RECOVERY_RATE_FOR_SHORT = 'a';
        public const char FIXING_PRICE = 'W';
        public const char CASH_RATE = 'X';
        public const char SECURITY_TRADING_STATE_PHASE = 'c';
        public const char PREVIOUS_TRADE = 'g';

    }

    /// <summary>
    /// MDEntryPx Field
    /// </summary>/
    public sealed class MDEntryPx : DecimalField
    {
        public const int TAG = 270;

        public MDEntryPx()
            : base(Tags.MDEntryPx) { }
        public MDEntryPx(Decimal val)
            : base(Tags.MDEntryPx, val) { }

    }

    /// <summary>
    /// MDEntrySize Field
    /// </summary>/
    public sealed class MDEntrySize : DecimalField
    {
        public const int TAG = 271;

        public MDEntrySize()
            : base(Tags.MDEntrySize) { }
        public MDEntrySize(Decimal val)
            : base(Tags.MDEntrySize, val) { }

    }

    /// <summary>
    /// MDEntryDate Field
    /// </summary>/
    public sealed class MDEntryDate : DateOnlyField
    {
        public const int TAG = 272;

        public MDEntryDate()
            : base(Tags.MDEntryDate) { }
        public MDEntryDate(DateTime val)
            : base(Tags.MDEntryDate, val) { }

    }

    /// <summary>
    /// MDEntryTime Field
    /// </summary>/
    public sealed class MDEntryTime : TimeOnlyField
    {
        public const int TAG = 273;

        public MDEntryTime()
            : base(Tags.MDEntryTime) { }
        public MDEntryTime(DateTime val)
            : base(Tags.MDEntryTime, val) { }
        public MDEntryTime(DateTime val, bool showMilliseconds)
            : base(Tags.MDEntryTime, val, showMilliseconds) { }
        public MDEntryTime(DateTime val, Converters.TimeStampPrecision precision)
            : base(Tags.MDEntryTime, val, precision) { }

    }

    /// <summary>
    /// SecurityValidityTimestamp Field
    /// </summary>/
    public sealed class SecurityValidityTimestamp : DateTimeField
    {
        public const int TAG = 6938;

        public SecurityValidityTimestamp()
            : base(Tags.SecurityValidityTimestamp) { }
        public SecurityValidityTimestamp(DateTime val)
            : base(Tags.SecurityValidityTimestamp, val) { }
        public SecurityValidityTimestamp(DateTime val, bool showMilliseconds)
            : base(Tags.SecurityValidityTimestamp, val, showMilliseconds) { }
        public SecurityValidityTimestamp(DateTime val, Converters.TimeStampPrecision precision)
            : base(Tags.SecurityValidityTimestamp, val, precision) { }

    }

    /// <summary>
    /// MDEntryID Field
    /// </summary>/
    public sealed class MDEntryID : StringField
    {
        public const int TAG = 278;

        public MDEntryID()
            : base(Tags.MDEntryID) { }
        public MDEntryID(string val)
            : base(Tags.MDEntryID, val) { }

    }

    /// <summary>
    /// MDUpdateAction Field
    /// </summary>/
    public sealed class MDUpdateAction : CharField
    {
        public const int TAG = 279;

        public MDUpdateAction()
            : base(Tags.MDUpdateAction) { }
        public MDUpdateAction(char val)
            : base(Tags.MDUpdateAction, val) { }


        // Field Enumerations
        public const char NEW = '0';
        public const char CHANGE = '1';
        public const char DELETE = '2';
        public const char DELETE_THRU = '3';
        public const char DELETE_FROM = '4';
        public const char OVERLAY = '5';
    }

    /// <summary>
    /// MDReqRejReason Field
    /// </summary>/
    public sealed class MDReqRejReason : CharField
    {
        public const int TAG = 281;

        public MDReqRejReason()
            : base(Tags.MDReqRejReason) { }
        public MDReqRejReason(char val)
            : base(Tags.MDReqRejReason, val) { }


        // Field Enumerations
        public const char UNKNOWN_SYMBOL = '0';
        public const char DUPLICATE_MDREQID = '1';
        public const char INSUFFICIENT_BANDWIDTH = '2';
        public const char INSUFFICIENT_PERMISSIONS = '3';
        public const char UNSUPPORTED_SUBSCRIPTIONREQUESTTYPE = '4';
        public const char UNSUPPORTED_MARKETDEPTH = '5';
        public const char UNSUPPORTED_MDUPDATETYPE = '6';
        public const char UNSUPPORTED_AGGREGATEDBOOK = '7';
        public const char UNSUPPORTED_MDENTRYTYPE = '8';
        public const char UNSUPPORTED_TRADINGSESSIONID = '9';
        public const char UNSUPPORTED_SCOPE = 'A';
        public const char UNSUPPORTED_OPENCLOSESETTLEFLAG = 'B';
        public const char UNSUPPORTED_MDIMPLICITDELETE = 'C';
        public const char INSUFFICIENT_CREDIT = 'D';
    }

    /// <summary>
    /// MDEntryBuyer Field
    /// </summary>/
    public sealed class MDEntryBuyer : StringField
    {
        public const int TAG = 288;

        public MDEntryBuyer()
            : base(Tags.MDEntryBuyer) { }
        public MDEntryBuyer(string val)
            : base(Tags.MDEntryBuyer, val) { }

    }

    /// <summary>
    /// MDEntrySeller Field
    /// </summary>/
    public sealed class MDEntrySeller : StringField
    {
        public const int TAG = 289;

        public MDEntrySeller()
            : base(Tags.MDEntrySeller) { }
        public MDEntrySeller(string val)
            : base(Tags.MDEntrySeller, val) { }

    }

    /// <summary>
    /// MDEntryPositionNo Field
    /// </summary>/
    public sealed class MDEntryPositionNo : IntField
    {
        public const int TAG = 290;

        public MDEntryPositionNo()
            : base(Tags.MDEntryPositionNo) { }
        public MDEntryPositionNo(int val)
            : base(Tags.MDEntryPositionNo, val) { }

    }

    /// <summary>
    /// SecurityReqID Field
    /// </summary>/
    public sealed class SecurityReqID : StringField
    {
        public const int TAG = 320;

        public SecurityReqID()
            : base(Tags.SecurityReqID) { }
        public SecurityReqID(string val)
            : base(Tags.SecurityReqID, val) { }

    }

    /// <summary>
    /// SecurityResponseID Field
    /// </summary>/
    public sealed class SecurityResponseID : StringField
    {
        public const int TAG = 322;

        public SecurityResponseID()
            : base(Tags.SecurityResponseID) { }
        public SecurityResponseID(string val)
            : base(Tags.SecurityResponseID, val) { }

    }

    /// <summary>
    /// EncodedTextLen Field
    /// </summary>/
    public sealed class EncodedTextLen : IntField
    {
        public const int TAG = 354;

        public EncodedTextLen()
            : base(Tags.EncodedTextLen) { }
        public EncodedTextLen(int val)
            : base(Tags.EncodedTextLen, val) { }

    }

    /// <summary>
    /// EncodedText Field
    /// </summary>/
    public sealed class EncodedText : StringField
    {
        public const int TAG = 355;

        public EncodedText()
            : base(Tags.EncodedText) { }
        public EncodedText(string val)
            : base(Tags.EncodedText, val) { }

    }

    /// <summary>
    /// LastMsgSeqNumProcessed Field
    /// </summary>/
    public sealed class LastMsgSeqNumProcessed : IntField
    {
        public const int TAG = 369;

        public LastMsgSeqNumProcessed()
            : base(Tags.LastMsgSeqNumProcessed) { }
        public LastMsgSeqNumProcessed(int val)
            : base(Tags.LastMsgSeqNumProcessed, val) { }

    }

    /// <summary>
    /// OnBehalfOfSendingTime Field
    /// </summary>/
    public sealed class OnBehalfOfSendingTime : DateTimeField
    {
        public const int TAG = 370;

        public OnBehalfOfSendingTime()
            : base(Tags.OnBehalfOfSendingTime) { }
        public OnBehalfOfSendingTime(DateTime val)
            : base(Tags.OnBehalfOfSendingTime, val) { }
        public OnBehalfOfSendingTime(DateTime val, bool showMilliseconds)
            : base(Tags.OnBehalfOfSendingTime, val, showMilliseconds) { }
        public OnBehalfOfSendingTime(DateTime val, Converters.TimeStampPrecision precision)
            : base(Tags.OnBehalfOfSendingTime, val, precision) { }

    }

    /// <summary>
    /// RefTagID Field
    /// </summary>/
    public sealed class RefTagID : IntField
    {
        public const int TAG = 371;

        public RefTagID()
            : base(Tags.RefTagID) { }
        public RefTagID(int val)
            : base(Tags.RefTagID, val) { }

    }

    /// <summary>
    /// RefMsgType Field
    /// </summary>/
    public sealed class RefMsgType : StringField
    {
        public const int TAG = 372;

        public RefMsgType()
            : base(Tags.RefMsgType) { }
        public RefMsgType(string val)
            : base(Tags.RefMsgType, val) { }

    }

    /// <summary>
    /// SessionRejectReason Field
    /// </summary>/
    public sealed class SessionRejectReason : IntField
    {
        public const int TAG = 373;

        public SessionRejectReason()
            : base(Tags.SessionRejectReason) { }
        public SessionRejectReason(int val)
            : base(Tags.SessionRejectReason, val) { }


        // Field Enumerations
        public const int INVALID_TAG_NUMBER = 0;
        public const int REQUIRED_TAG_MISSING = 1;
        public const int SENDINGTIME_ACCURACY_PROBLEM = 10;
        public const int INVALID_MSGTYPE = 11;
        public const int XML_VALIDATION_ERROR = 12;
        public const int TAG_APPEARS_MORE_THAN_ONCE = 13;
        public const int TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER = 14;
        public const int REPEATING_GROUP_FIELDS_OUT_OF_ORDER = 15;
        public const int INCORRECT_NUMINGROUP_COUNT_FOR_REPEATING_GROUP = 16;
        public const int NON_DATA_VALUE_INCLUDES_FIELD_DELIMITER = 17;
        public const int TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE = 2;
        public const int UNDEFINED_TAG = 3;
        public const int TAG_SPECIFIED_WITHOUT_A_VALUE = 4;
        public const int VALUE_IS_INCORRECT = 5;
        public const int INCORRECT_DATA_FORMAT_FOR_VALUE = 6;
        public const int DECRYPTION_PROBLEM = 7;
        public const int SIGNATURE_PROBLEM = 8;
        public const int COMPID_PROBLEM = 9;
        public const int OTHER = 99;
        public const int INVALID_UNSUPPORTED_APPLICATION_VERSION = 18;
        public const int E = 11;
    }

    /// <summary>
    /// BusinessRejectRefID Field
    /// </summary>/
    public sealed class BusinessRejectRefID : StringField
    {
        public const int TAG = 379;

        public BusinessRejectRefID()
            : base(Tags.BusinessRejectRefID) { }
        public BusinessRejectRefID(string val)
            : base(Tags.BusinessRejectRefID, val) { }

    }

    /// <summary>
    /// BusinessRejectReason Field
    /// </summary>/
    public sealed class BusinessRejectReason : IntField
    {
        public const int TAG = 380;

        public BusinessRejectReason()
            : base(Tags.BusinessRejectReason) { }
        public BusinessRejectReason(int val)
            : base(Tags.BusinessRejectReason, val) { }


        // Field Enumerations
        public const int OTHER = 0;
        public const int UNKNOWN_ID = 1;
        public const int UNKNOWN_SECURITY = 2;
        public const int UNSUPPORTED_MESSAGE_TYPE = 3;
        public const int APPLICATION_NOT_AVAILABLE = 4;
        public const int CONDITIONALLY_REQUIRED_FIELD_MISSING = 5;
        public const int NOT_AUTHORIZED = 6;
        public const int DELIVERTO_FIRM_NOT_AVAILABLE_AT_THIS_TIME = 7;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int UNKNOWN_MESSAGE_TYPE = 3;
        public const int UNKOWN_ID = 1;
    }

    /// <summary>
    /// MaxMessageSize Field
    /// </summary>/
    public sealed class MaxMessageSize : IntField
    {
        public const int TAG = 383;

        public MaxMessageSize()
            : base(Tags.MaxMessageSize) { }
        public MaxMessageSize(int val)
            : base(Tags.MaxMessageSize, val) { }

    }

    /// <summary>
    /// NoMsgTypes Field
    /// </summary>/
    public sealed class NoMsgTypes : IntField
    {
        public const int TAG = 384;

        public NoMsgTypes()
            : base(Tags.NoMsgTypes) { }
        public NoMsgTypes(int val)
            : base(Tags.NoMsgTypes, val) { }

    }

    /// <summary>
    /// MsgDirection Field
    /// </summary>/
    public sealed class MsgDirection : CharField
    {
        public const int TAG = 385;

        public MsgDirection()
            : base(Tags.MsgDirection) { }
        public MsgDirection(char val)
            : base(Tags.MsgDirection, val) { }


        // Field Enumerations
        public const char RECEIVE = 'R';
        public const char SEND = 'S';
    }

    /// <summary>
    /// ExpireDate Field
    /// </summary>/
    public sealed class ExpireDate : StringField
    {
        public const int TAG = 432;

        public ExpireDate()
            : base(Tags.ExpireDate) { }
        public ExpireDate(string val)
            : base(Tags.ExpireDate, val) { }

    }

    /// <summary>
    /// SecurityIDSource Field
    /// </summary>/
    public sealed class SecurityIDSource : StringField
    {
        public const int TAG = 22;

        public SecurityIDSource()
            : base(Tags.SecurityIDSource) { }
        public SecurityIDSource(string val)
            : base(Tags.SecurityIDSource, val) { }


        // Field Enumerations
        public const string CUSIP = "1";
        public const string SEDOL = "2";
        public const string QUIK = "3";
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string ISO_CURRENCY_CODE = "6";
        public const string ISO_COUNTRY_CODE = "7";
        public const string EXCHANGE_SYMBOL = "8";
        public const string CONSOLIDATED_TAPE_ASSOCIATION = "9";
        public const string BLOOMBERG_SYMBOL = "A";
        public const string WERTPAPIER = "B";
        public const string DUTCH = "C";
        public const string VALOREN = "D";
        public const string SICOVAM = "E";
        public const string BELGIAN = "F";
        public const string COMMON = "G";
        public const string CLEARING_HOUSE = "H";
        public const string ISDA_FPML_PRODUCT_SPECIFICATION = "I";
        public const string OPTION_PRICE_REPORTING_AUTHORITY = "J";
        public const string LETTER_OF_CREDIT = "L";
        public const string ISDA_FPML_PRODUCT_URL = "K";
        public const string MARKETPLACE_ASSIGNED_IDENTIFIER = "M";
        public const string CLEARING_HOUSE_CLEARING_ORGANIZATION = "H";
        public const string OPTIONS_PRICE_REPORTING_AUTHORITY = "J";
    }

    /// <summary>
    /// LastQty Field
    /// </summary>/
    public sealed class LastQty : DecimalField
    {
        public const int TAG = 32;

        public LastQty()
            : base(Tags.LastQty) { }
        public LastQty(Decimal val)
            : base(Tags.LastQty, val) { }

    }

    /// <summary>
    /// Quantity Field
    /// </summary>/
    public sealed class Quantity : DecimalField
    {
        public const int TAG = 53;

        public Quantity()
            : base(Tags.Quantity) { }
        public Quantity(Decimal val)
            : base(Tags.Quantity, val) { }

    }

    /// <summary>
    /// TestMessageIndicator Field
    /// </summary>/
    public sealed class TestMessageIndicator : BooleanField
    {
        public const int TAG = 464;

        public TestMessageIndicator()
            : base(Tags.TestMessageIndicator) { }
        public TestMessageIndicator(Boolean val)
            : base(Tags.TestMessageIndicator, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }

    /// <summary>
    /// Username Field
    /// </summary>/
    public sealed class Username : StringField
    {
        public const int TAG = 553;

        public Username()
            : base(Tags.Username) { }
        public Username(string val)
            : base(Tags.Username, val) { }

    }

    /// <summary>
    /// Password Field
    /// </summary>/
    public sealed class Password : StringField
    {
        public const int TAG = 554;

        public Password()
            : base(Tags.Password) { }
        public Password(string val)
            : base(Tags.Password, val) { }

    }

    /// <summary>
    /// SecurityListRequestType Field
    /// </summary>/
    public sealed class SecurityListRequestType : IntField
    {
        public const int TAG = 559;

        public SecurityListRequestType()
            : base(Tags.SecurityListRequestType) { }
        public SecurityListRequestType(int val)
            : base(Tags.SecurityListRequestType, val) { }


        // Field Enumerations
        public const int RF = 0;
        public const int FUTURE = 1;
    }

    /// <summary>
    /// SecurityRequestResult Field
    /// </summary>/
    public sealed class SecurityRequestResult : IntField
    {
        public const int TAG = 560;

        public SecurityRequestResult()
            : base(Tags.SecurityRequestResult) { }
        public SecurityRequestResult(int val)
            : base(Tags.SecurityRequestResult, val) { }


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_INSTRUMENTS_FOUND_THAT_MATCH_SELECTION_CRITERIA = 2;
        public const int NOT_AUTHORIZED_TO_RETRIEVE_INSTRUMENT_DATA = 3;
        public const int INSTRUMENT_DATA_TEMPORARILY_UNAVAILABLE = 4;
        public const int REQUEST_FOR_INSTRUMENT_DATA_NOT_SUPPORTED = 5;
    }


    /// <summary>
    /// RoundLot Field
    /// </summary>/
    public sealed class RoundLot : DecimalField
    {
        public const int TAG = 561;

        public RoundLot()
            : base(Tags.RoundLot) { }
        public RoundLot(Decimal val)
            : base(Tags.RoundLot, val) { }

    }

    /// <summary>
    /// TotNoRelatedSym Field
    /// </summary>/
    public sealed class TotNoRelatedSym : IntField
    {
        public const int TAG = 393;

        public TotNoRelatedSym()
            : base(Tags.TotNoRelatedSym) { }
        public TotNoRelatedSym(int val)
            : base(Tags.TotNoRelatedSym, val) { }

    }

    /// <summary>
    /// NextExpectedMsgSeqNum Field
    /// </summary>/
    public sealed class NextExpectedMsgSeqNum : IntField
    {
        public const int TAG = 789;

        public NextExpectedMsgSeqNum()
            : base(Tags.NextExpectedMsgSeqNum) { }
        public NextExpectedMsgSeqNum(int val)
            : base(Tags.NextExpectedMsgSeqNum, val) { }

    }

    /// <summary>
    /// ApplVerID Field
    /// </summary>/
    public sealed class ApplVerID : StringField
    {
        public const int TAG = 1128;

        public ApplVerID()
            : base(Tags.ApplVerID) { }
        public ApplVerID(string val)
            : base(Tags.ApplVerID, val) { }


        // Field Enumerations
        public const string FIX27 = "0";
        public const string FIX30 = "1";
        public const string FIX40 = "2";
        public const string FIX41 = "3";
        public const string FIX42 = "4";
        public const string FIX43 = "5";
        public const string FIX44 = "6";
        public const string FIX50 = "7";
        public const string FIX50SP1 = "8";
        public const string FIX50SP2 = "9";
    }

    /// <summary>
    /// DefaultApplVerID Field
    /// </summary>/
    public sealed class DefaultApplVerID : StringField
    {
        public const int TAG = 1137;

        public DefaultApplVerID()
            : base(Tags.DefaultApplVerID) { }
        public DefaultApplVerID(string val)
            : base(Tags.DefaultApplVerID, val) { }

    }

    /// <summary>
    /// MarketUpdateAction Field
    /// </summary>/
    public sealed class MarketUpdateAction : CharField
    {
        public const int TAG = 1395;

        public MarketUpdateAction()
            : base(Tags.MarketUpdateAction) { }
        public MarketUpdateAction(char val)
            : base(Tags.MarketUpdateAction, val) { }


        // Field Enumerations
        public const char ADD = 'A';
        public const char DELETE = 'D';
        public const char MODIFY = 'M';
    }

    /// <summary>
    /// PU Field
    /// </summary>
    public sealed class PU : DecimalField
    {
        public const int TAG = 1003;

        public PU() : base(Tags.PU)
        {

        }

        public PU(Decimal val) : base(Tags.PU, val)
        {

        }
    }

    /// <summary>
    /// OrderBid Field
    /// </summary>
    public sealed class OrderBid : StringField
    {
        public const int TAG = 1006;

        public OrderBid() : base(Tags.OrderBid)
        {

        }

        public OrderBid(string val) : base(Tags.OrderBid, val)
        {

        }
    }

    /// <summary>
    /// OrderOffer Field
    /// </summary>
    public sealed class OrderOffer : StringField
    {
        public const int TAG = 1007;

        public OrderOffer() : base(Tags.OrderOffer)
        {

        }

        public OrderOffer(string val) : base(Tags.OrderOffer, val)
        {

        }
    }

    /// <summary>
    /// IsAttack Field
    /// </summary>
    public sealed class IsAttack : BooleanField
    {
        public const int TAG = 1009;

        public IsAttack() : base(Tags.IsAttack)
        {

        }

        public IsAttack(bool val) : base(Tags.IsAttack, val)
        {

        }
    }

    public sealed class HasOffer : CharField
    {
        public const int TAG = 1002;

        public HasOffer() : base(Tags.HasOffer)
        {

        }

        public HasOffer(char val) : base(Tags.HasOffer, val)
        {

        }

        // Field Enumerations
        public const char YES = 'Y';
        public const char NO = 'N';
       
    }

    public sealed class IsTest : CharField
    {
        public const int TAG = 1004;

        public IsTest() : base(Tags.IsTest)
        {

        }

        public IsTest(char val) : base(Tags.IsTest, val)
        {

        }

        // Field Enumerations
        public const char YES = 'Y';
        public const char NO = 'N';
       
    }

    public sealed class LastFragment : CharField
    {
        public const int TAG = 893;

        public LastFragment() : base(Tags.LastFragment)
        {

        }

        public LastFragment(char val) : base(Tags.LastFragment, val)
        {

        }

        // Field Enumerations
        public const char YES = 'Y';
        public const char NO = 'N';
       
    }

    /// <summary>
    /// RefCompID Field
    /// </summary>
    public sealed class StatusValue : IntField
    {
        public const int TAG = 928;

        public StatusValue() : base(Tags.StatusValue)
        {

        }

        public StatusValue(int val) : base(Tags.StatusValue, val)
        {

        }

        // Field Enumerations
        public const int CONNECTED = 0;
        public const int DISCONNECTED = 1;
    }

    /// <summary>
    /// SecurityTradingStatus Field
    /// </summary>
    public sealed class SecurityTradingStatus : StringField
    {
        public const int TAG = 326;

        public SecurityTradingStatus() : base(Tags.SecurityTradingStatus)
        {

        }

        public SecurityTradingStatus(string val) : base(Tags.SecurityTradingStatus, val)
        {

        }

        public const string READY_TO_TRADE = "17";
        public const string TRADING_HALT = "02";
        public const string NO_OPEN_NO_RESUME = "04";
        public const string NOT_AVAILABLE_FOR_TRADING = "18";
        public const string UNKNOWN_OR_INVALID = "20";
        public const string PRE_OPEN = "21";
    }

    /// <summary>
    /// StatusText Field
    /// </summary>
    public sealed class StatusText : StringField
    {
        public const int TAG = 929;

        public StatusText() : base(Tags.StatusText)
        {

        }

        public StatusText(string val) : base(Tags.StatusText, val)
        {

        }
    }

    /// <summary>
    /// RefCompID Field
    /// </summary>
    public sealed class RefCompID : IntField
    {
        public const int TAG = 930;

        public RefCompID() : base(Tags.RefCompID)
        {

        }

        public RefCompID(int val) : base(Tags.RefCompID, val)
        {

        }

        // Field Enumerations
        public const int B3 = 0;
        public const int MATCHING = 1;
        public const int DIFUSOR = 2;
    }

    /// <summary>
    /// NetworkResponseID Field
    /// </summary>
    public sealed class NetworkResponseID : StringField
    {
        public const int TAG = 932;

        public NetworkResponseID() : base(Tags.NetworkResponseID)
        {

        }

        public NetworkResponseID(string val) : base(Tags.NetworkResponseID, val)
        {

        }
    }

    /// <summary>
    /// NoCompIDs Field
    /// </summary>
    public sealed class NoCompIDs : IntField
    {
        public const int TAG = 936;

        public NoCompIDs() : base(Tags.NoCompIDs)
        {

        }

        public NoCompIDs(int val) : base(Tags.NoCompIDs, val)
        {

        }
    }

    /// <summary>
    /// OrderStatus Field
    /// </summary>
    public sealed class OrderStatus : CharField
    {
        public const int TAG = 1010;

        public OrderStatus() : base(Tags.OrderStatus)
        {

        }

        public OrderStatus(char val) : base(Tags.OrderStatus, val)
        {

        }

        // Field Enumerations
        public const char PENDING_NEW = '0';
        public const char NEW = '1';
        public const char PENDING_REPLACE = '2';
        public const char REPLACED = '3';
        public const char PENDING_CANCEL = '4';
        public const char CANCELED = '5';
        public const char PARTIALLY_FILLED = '6';
        public const char FILLED = '7';
        public const char REJECTED = '8';
        public const char EXPIRED = '9';
        public const char INCORRECT_BALANCE = 'A';
        public const char PARTIALLY_FILLED_CANCELED = 'B';

    }

    /// <summary>
    /// TradeStatus Field
    /// </summary>
    public sealed class TradeStatus : CharField
    {
        public const int TAG = 1102;

        public TradeStatus() : base(Tags.TradeStatus)
        {

        }

        public TradeStatus(char val) : base(Tags.TradeStatus, val)
        {

        }

        // Field Enumerations
        public const char PENDING = '0';
        public const char CONFIRMED = '1';
        public const char REJECTED = '2';
        public const char CANCELED = '3';
    }

    /// <summary>
    /// RiskStatus Field
    /// </summary>
    public sealed class RiskStatus : CharField
    {
        public const int TAG = 1103;

        public RiskStatus() : base(Tags.RiskStatus)
        {

        }

        public RiskStatus(char val) : base(Tags.RiskStatus, val)
        {

        }

        // Field Enumerations
        public const char CONFIRMED = '1';
        public const char TUNNEL_REJECTED = '2';
    }

    /// <summary>
    /// OrigTrade Field
    /// </summary>
    public sealed class OrigTrade : CharField
    {
        public const int TAG = 1012;

        public OrigTrade() : base(Tags.OrigTrade)
        {

        }

        public OrigTrade(char val) : base(Tags.OrigTrade, val)
        {

        }

        // Field Enumerations
        public const char ROP = '0';
        public const char BOOK = '1';
    }


    /// <summary>
    /// SourceAddress Field
    /// </summary>
    public sealed class SourceAddress : StringField
    {
        public const int TAG = 1029;

        public SourceAddress() : base(Tags.SourceAddress)
        {

        }

        public SourceAddress(string val) : base(Tags.SourceAddress, val)
        {

        }
    }

    /// <summary>
    /// AccountID Field
    /// </summary>
    public sealed class AccountID : StringField
    {
        public const int TAG = 1031;

        public AccountID() : base(Tags.AccountID)
        {

        }

        public AccountID(string val) : base(Tags.AccountID, val)
        {

        }
    }

    /// <summary>
    /// AccountName Field
    /// </summary>
    public sealed class AccountName : StringField
    {
        public const int TAG = 1039;

        public AccountName() : base(Tags.AccountName)
        {

        }

        public AccountName(string val) : base(Tags.AccountName, val)
        {

        }
    }

    /// <summary>
    /// STax Field
    /// </summary>
    public sealed class STax : StringField
    {
        public const int TAG = 1040;

        public STax() : base(Tags.STax)
        {

        }

        public STax(string val) : base(Tags.STax, val)
        {

        }
    }

    /// <summary>
    /// SPercentageTax Field
    /// </summary>
    public sealed class SPercentageTax : StringField
    {
        public const int TAG = 1041;

        public SPercentageTax() : base(Tags.SPercentageTax)
        {

        }

        public SPercentageTax(string val) : base(Tags.SPercentageTax, val)
        {

        }
    }

    /// <summary>
    /// LiquidationType Field
    /// </summary>
    public sealed class LiquidationType : CharField
    {
        public const int TAG = 1045;

        public LiquidationType() : base(Tags.LiquidationType)
        {

        }

        public LiquidationType(char val) : base(Tags.LiquidationType, val)
        {

        }

        // Field Enumerations
        public const char D0 = '0';
        public const char D1 = '1';
        public const char D2 = '2';
    }

    public sealed class OpenCloseSettlFlag : StringField
    {
        public const int TAG = 286;

        public OpenCloseSettlFlag() : base(Tags.OpenCloseSettlFlag)
        {

        }

        public OpenCloseSettlFlag(string val) : base(Tags.OpenCloseSettlFlag, val)
        {

        }

        public const string DAILY_OPEN_CLOSE_SETTLEMENT_ENTRY = "0";
        public const string SESSION_OPEN_CLOSE_SETTLEMENT_ENTRY = "1";
        public const string DELIVERY_SETTLEMENT_ENTRY = "2";
        public const string EXPECTED_ENTRY = "3";
        public const string ENTRY_FROM_PREVIOUS_BUSINESS_DAY = "4";
        public const string THEORETICAL_PRICE_VALUE = "5";

    } 

    /// <summary>
    /// PriceType Field
    /// </summary>/
    public sealed class PriceType : IntField
    {
        public const int TAG = 423;

        public PriceType()
            : base(Tags.PriceType) { }
        public PriceType(int val)
            : base(Tags.PriceType, val) { }

        public const int PERCENTAGE = 1;
        public const int PER_UNIT = 2;
        public const int FIXED_AMOUNT = 3;
    }

    /// <summary>
    /// SettlPriceType Field
    /// </summary>/
    public sealed class SettlPriceType : IntField
    {
        public const int TAG = 731;

        public SettlPriceType()
            : base(Tags.SettlPriceType) { }
        public SettlPriceType(int val)
            : base(Tags.SettlPriceType, val) { }

        public const int FINAL = 1;
        public const int THEORETICAL = 2;
        public const int UPDATED = 3;
    }

    /// <summary>
    /// BrokerID Field
    /// </summary>
    public sealed class BrokerID : IntField
    {
        public const int TAG = 1047;

        public BrokerID() : base(Tags.BrokerID)
        {

        }

        public BrokerID(int val) : base(Tags.BrokerID, val)
        {

        }
    }

    /// <summary>
    /// UserEntering Field
    /// </summary>
    public sealed class UserEntering : StringField
    {
        public const int TAG = 1062;

        public UserEntering() : base(Tags.UserEntering)
        {

        }

        public UserEntering(string val) : base(Tags.UserEntering, val)
        {

        }
    } 

    /// <summary>
    /// SLastTax Field
    /// </summary>
    public sealed class SLastPU : StringField
    {
        public const int TAG = 30014;

        public SLastPU() : base(Tags.SLastPU)
        {

        }

        public SLastPU(string val) : base(Tags.SLastPU, val)
        {

        }
    }

    /// <summary>
    /// ParentOrderID Field
    /// </summary>
    public sealed class ParentOrderID : StringField
    {
        public const int TAG = 30061;

        public ParentOrderID() : base(Tags.ParentOrderID)
        {

        }

        public ParentOrderID(string val) : base(Tags.ParentOrderID, val)
        {

        }
    }

    /// <summary>
    /// GroupID Field
    /// </summary>
    public sealed class GroupID : IntField
    {
        public const int TAG = 30088;

        public GroupID() : base(Tags.GroupID)
        {

        }

        public GroupID(int val) : base(Tags.GroupID, val)
        {

        }
    }

    /// <summary>
    /// MemoID Field
    /// </summary>
    public sealed class MemoID : IntField
    {
        public const int TAG = 31018;

        public MemoID() : base(Tags.MemoID)
        {

        }

        public MemoID(int val) : base(Tags.MemoID, val)
        {

        }
    }

    public sealed class SecurityGroup : StringField
    {
        public const int TAG = 1151;

        public SecurityGroup() : base(Tags.SecurityGroup) 
        { 
        
        }

        public SecurityGroup(string val) : base(Tags.SecurityGroup, val)
        { 
        
        }
    }


    /// <summary>
    /// SLastTax Field
    /// </summary>
    public sealed class SLastTax : StringField
    {
        public const int TAG = 1065;

        public SLastTax() : base(Tags.SLastTax)
        {

        }

        public SLastTax(string val) : base(Tags.SLastTax, val)
        {

        }
    }

    /// <summary>
    /// SAvgTax Field
    /// </summary>
    public sealed class SAvgTax : StringField
    {
        public const int TAG = 1066;

        public SAvgTax() : base(Tags.SAvgTax)
        {

        }

        public SAvgTax(string val) : base(Tags.SAvgTax, val)
        {

        }
    }

    /// <summary>
    /// SPU Field
    /// </summary>
    public sealed class SPU : StringField
    {
        public const int TAG = 1067;

        public SPU() : base(Tags.SPU)
        {

        }

        public SPU(string val) : base(Tags.SPU, val)
        {

        }
    }
    
    /// <summary>
    /// UniqueTradeID Field
    /// </summary>
    public sealed class UniqueTradeID : StringField
    {
        public const int TAG = 6032;

        public UniqueTradeID() : base(Tags.UniqueTradeID)
        {

        }

        public UniqueTradeID(string val) : base(Tags.UniqueTradeID, val)
        {

        }
    }

    /// <summary>
    /// SecondaryOrderID Field
    /// </summary>
    public sealed class SecondaryOrderID : StringField
    {
        public const int TAG = 198;

        public SecondaryOrderID() : base(Tags.SecondaryOrderID)
        {

        }

        public SecondaryOrderID(string val) : base(Tags.SecondaryOrderID, val)
        {

        }
    }

    /// <summary>
    /// MDReqRejReason Field
    /// </summary>
    public sealed class AltMDSourceID : StringField
    {

        public const int TAG = 817;
        public AltMDSourceID() : base(Tags.AltMDSourceID)
        {

        }

        public AltMDSourceID(string val) : base(Tags.AltMDSourceID, val)
        {

        }
    }

    public sealed class OrderProfile : CharField
    {
        public const int TAG = 30064;

        public OrderProfile() : base(Tags.OrderProfile)
        {

        }

        public OrderProfile(char val) : base(Tags.OrderProfile, val)
        {

        }

        // Field Enumerations
        public const char MANAGER = '0';
        public const char BROKER = '1';
        public const char DEALER = '2';
       
    }

    /// <summary>
    /// OrigClOrdID Field
    /// </summary>/
    public sealed class OrigClOrdID : StringField
    {
        public const int TAG = 41;

        public OrigClOrdID()
            : base(Tags.OrigClOrdID) { }
        public OrigClOrdID(string val)
            : base(Tags.OrigClOrdID, val) { }

    }

    /// <summary>
    /// ManagerID Field
    /// </summary>/
    public sealed class ManagerID : IntField
    {
        public const int TAG = 1048;

        public ManagerID()
            : base(Tags.ManagerID) { }
        public ManagerID(int val)
            : base(Tags.ManagerID, val) { }

    }
    
    /// <summary>
    /// OrderDate Field
    /// </summary>/
    public sealed class OrderDate : IntField
    {
        public const int TAG = 1049;
        public OrderDate()
            : base(Tags.OrderDate) { }
        public OrderDate(int val)
            : base(Tags.OrderDate, val) { }
    }

    /// <summary>
    /// LogonRejCode Field
    /// </summary>
    public sealed class LogonRejCode : CharField
    {
        public const int TAG = 20118;

        public LogonRejCode() : base(Tags.LogonRejCode)
        {

        }

        public LogonRejCode(char val) : base(Tags.LogonRejCode, val)
        {

        }

        // Field Enumerations
        public const char INVALID_USERPASS = '0';
        public const char BLOCKED_USER = '1';
        public const char SESSION_IN_USE = '2';
        public const char ATTEMPT_TIMEOUT = '3';
        public const char DATABASE_ERROR = '4';
        public const char INVALID_IP = '5';
        public const char INVALID_RELEASE = '6';
        public const char RESET_BY_PEER = '7';
        public const char CONNECTION_REFUSED = '8';
        public const char NONE = '9';
        public const char DENIED = 'A';
    }

    /// <summary>
    /// RejectSource Field
    /// </summary>
    public sealed class RejectSource : CharField
    {
        public const int TAG = 20119;

        public RejectSource() : base(Tags.RejectSource)
        {

        }

        public RejectSource(char val) : base(Tags.RejectSource, val)
        {

        }

        // Field Enumerations
        public const char MATCHING = '0';
        public const char MARKET = '1';
        public const char CRYSTAL_BROKER = '2';
        public const char ALGO_SERVER = '3';
    }

    /// <summary>
    /// BuyQty Field
    /// </summary>
    public sealed class BuyQty : IntField
    {
        public const int TAG = 31000;

        public BuyQty() : base(Tags.BuyQty)
        {

        }

        public BuyQty(int val) : base(Tags.BuyQty, val)
        {

        }
    }

    /// <summary>
    /// SellQty Field
    /// </summary>
    public sealed class SellQty : IntField
    {
        public const int TAG = 31001;

        public SellQty() : base(Tags.SellQty)
        {

        }

        public SellQty(int val) : base(Tags.SellQty, val)
        {

        }
    }

    /// <summary>
    /// DIVertex Field
    /// </summary>
    public sealed class DIVertex : StringField
    {
        public const int TAG = 31002;

        public DIVertex() : base(Tags.DIVertex)
        {

        }

        public DIVertex(string val) : base(Tags.DIVertex, val)
        {

        }
    }

    /// <summary>
    /// DeltaNTNB Field
    /// </summary>
    public sealed class DeltaNTNB : StringField
    {
        public const int TAG = 31003;

        public DeltaNTNB() : base(Tags.DeltaNTNB)
        {

        }

        public DeltaNTNB(string val) : base(Tags.DeltaNTNB, val)
        {

        }
    }

    /// <summary>
    /// CurveNTNB Field
    /// </summary>
    public sealed class CurveNTNB : StringField
    {
        public const int TAG = 31004;

        public CurveNTNB() : base(Tags.CurveNTNB)
        {

        }

        public CurveNTNB(string val) : base(Tags.CurveNTNB, val)
        {

        }
    }

    /// <summary>
    /// ShiftNTNB Field
    /// </summary>
    public sealed class ShiftNTNB : StringField
    {
        public const int TAG = 31005;
        
        public ShiftNTNB() : base(Tags.ShiftNTNB)
        {

        }

        public ShiftNTNB(string val) : base(Tags.ShiftNTNB, val)
        {

        }
    }

    /// <summary>
    /// RewardLTN Field
    /// </summary>
    public sealed class RewardLTN : StringField
    {
        public const int TAG = 31006;

        public RewardLTN() : base(Tags.RewardLTN)
        {

        }

        public RewardLTN(string val) : base(Tags.RewardLTN, val)
        {

        }
    }

    /// <summary>
    /// SpreadFactor Field
    /// </summary>
    public sealed class SpreadFactor : StringField
    {
        public const int TAG = 31007;

        public SpreadFactor() : base(Tags.SpreadFactor)
        {

        }

        public SpreadFactor(string val) : base(Tags.SpreadFactor, val)
        {

        }
    }

    /// <summary>
    /// SendingTimeB3 Field
    /// </summary>/
    public sealed class SendingTimeB3 : DateTimeField
    {
        public const int TAG = 30100;

        public SendingTimeB3()
            : base(Tags.SendingTimeB3) { }
        public SendingTimeB3(DateTime val)
            : base(Tags.SendingTimeB3, val) { }
        public SendingTimeB3(DateTime val, bool showMilliseconds)
            : base(Tags.SendingTimeB3, val, showMilliseconds) { }
        public SendingTimeB3(DateTime val, Converters.TimeStampPrecision precision)
            : base(Tags.SendingTimeB3, val, precision) { }

    }
}
