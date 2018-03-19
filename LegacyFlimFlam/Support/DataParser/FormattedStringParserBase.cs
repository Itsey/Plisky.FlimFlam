using System;

namespace Plisky.FlimFlam {

    public abstract class FormattedStringParserBase : RawEntryParserChainLink {
        internal const string MSGFMT_XMLCOMMAND = "#XCM#";

        internal const string LOGMESSAGE = "#LOG#";
        internal const string LOGMESSAGEVERB = "#LGV#";
        internal const string LOGMESSAGEMINI = "#LGM#";
        internal const string INTERNALMSG = "#INT#";
        internal const string TRACEMESSAGEIN = "#TRI#";
        internal const string TRACEMESSAGEOUT = "#TRO#";
        //internal const string TRACEMESSAGE    = "#TRC#";

        internal const string ASSERTIONFAILED = "#AST#";

        internal const string MOREINFO = "#MOR#";
        internal const string COMMANDONLY = "#CMD#";
        internal const string ERRORMSG = "#ERR#";
        internal const string WARNINGMSG = "#WRN#";
        internal const string EXCEPTIONBLOCK = "#EXC#";
        internal const string EXCEPTIONDATA = "#EXD#";
        internal const string EXCSTART = "#EXS#";
        internal const string EXCEND = "#EXE#";

        internal const string SECTIONSTART = "#SEC#";  // Sections are used for timings now too.
        internal const string SECTIONEND = "#SXX#";

        internal const string RESOURCEEAT = "#REA#";
        internal const string RESOURCEPUKE = "#RPU#";
        internal const string RESOURCECOUNT = "#RSC#";
        internal const string TIMERNAME = "TexTimer";

        internal const string TIMER_SECTIONIDENTIFIER = "|TMRCHK|";  // Timers use sections for sending to Mex therefore this identifies a timer rather than a normal section
        internal const string TIMER_STRINGENDDELIMITER = "#X_X#]";
        internal const string TIMER_STRINGSTARTDELIMITER = "[#X_X#";
        internal const string TIMER_STRINGSTARTCONTENTSTRING = "TMRDATA" + TIMER_STRINGSTARTDELIMITER;
        internal const string AUTOTIMER_PREFIX = "TAT_PFX";

        internal const string TCPEND_MARKERTAG = "#TCPLIST-END#";
        internal const int TCPEND_MARKERTAGLEN = 13;    // TCPEND_MARKERTAG.Length doesent work.  Used to work in uber.

        //[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Long switch statement but very simple to read")]
        internal static string TraceCommandToString(MessageType theCommand) {
            switch (theCommand) {
                case MessageType.InfoMessage: return LOGMESSAGE;
                case MessageType.VerboseMessage: return LOGMESSAGEVERB;
                case MessageType.InternalMsg: return INTERNALMSG;
                case MessageType.TraceMessageIn: return TRACEMESSAGEIN;
                case MessageType.TraceMessageOut: return TRACEMESSAGEOUT;
                case MessageType.AssertionFailed: return ASSERTIONFAILED;
                case MessageType.MoreInfo: return MOREINFO;
                case MessageType.CommandOnly: return COMMANDONLY;
                case MessageType.CommandXML: return MSGFMT_XMLCOMMAND;
                case MessageType.ErrorMsg: return ERRORMSG;
                case MessageType.WarningMsg: return WARNINGMSG;
                case MessageType.ExceptionData: return EXCEPTIONDATA;
                case MessageType.ExceptionBlock: return EXCEPTIONBLOCK;
                case MessageType.ExceptionBlockStart: return EXCSTART;
                case MessageType.ExceptionBlockEnd: return EXCEND;
                case MessageType.SectionStart: return SECTIONSTART;
                case MessageType.SectionEnd: return SECTIONEND;
                case MessageType.ResourceEat: return RESOURCEEAT;
                case MessageType.ResourcePuke: return RESOURCEPUKE;
                case MessageType.ResourceCount: return RESOURCECOUNT;
            }

            throw new ArgumentException("Unreachable Code, the value (" + theCommand.ToString() + ")of the parameter is invalid, this code should not be executed.", "theCommand");
        }

        //[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Long switch statement but very simple to read")]
        internal static MessageType ConvertCommandTypeToMessageType(string theCmdText) {
            switch (theCmdText) {
                case LOGMESSAGE: return MessageType.InfoMessage;
                case LOGMESSAGEVERB: return MessageType.VerboseMessage;
                //case LOGMESSAGEMINI : return MessageType.LogMessageMini;
                case INTERNALMSG: return MessageType.InternalMsg;
                case TRACEMESSAGEIN: return MessageType.TraceMessageIn;
                case TRACEMESSAGEOUT: return MessageType.TraceMessageOut;
                //case TRACEMESSAGE   : return MessageType.TraceMessage;
                case ASSERTIONFAILED: return MessageType.AssertionFailed;
                case MOREINFO: return MessageType.MoreInfo;
                case COMMANDONLY: return MessageType.CommandOnly;
                case ERRORMSG: return MessageType.ErrorMsg;
                case WARNINGMSG: return MessageType.WarningMsg;
                case EXCEPTIONBLOCK: return MessageType.ExceptionBlock;
                case EXCEPTIONDATA: return MessageType.ExceptionData;
                case EXCSTART: return MessageType.ExceptionBlockStart;
                case EXCEND: return MessageType.ExceptionBlockEnd;
                case SECTIONSTART: return MessageType.SectionStart;
                case SECTIONEND: return MessageType.SectionEnd;
                case RESOURCEEAT: return MessageType.ResourceEat;
                case RESOURCEPUKE: return MessageType.ResourcePuke;
                case RESOURCECOUNT: return MessageType.ResourceCount;
                case MSGFMT_XMLCOMMAND: return MessageType.CommandXML;
            }

            throw new ArgumentException("Unreachable Code, the value of the parameter is invalid, this code should not be executed.", "theCmdText");
        }
    }
}