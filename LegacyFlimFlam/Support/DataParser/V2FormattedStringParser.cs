using Plisky.FlimFlam.Model;
using System.Text.RegularExpressions;

namespace Plisky.FlimFlam {

    /// <summary>
    /// This identifys the internal structure of the trace message.  The helper functions here
    /// depend on this internal structure and are all kept here.  There should be no dependance
    /// on the structure of the string outside of thsi class.
    ///
    /// {[MACHINENAME][PROCESSID][THREADID][NETTHREADID][MODULENAME][LINENUMBER][MOREDATA]}#CMD#TEXTOFDEBUGSTRING
    ///
    /// Where MACHINENAME = Current machine name taken from Environment
    /// Where PROCESSID   = The PID assigned to the process that outputed the string
    /// where THREADID    = The numeric ID assigned to the OS Thread running the commands
    /// where NETTHREADID = The name of the .net thread running the command.
    /// where MODULENAME  = The cs filename that was executing the commands
    /// where LINENUMBER  = the numeric line number that the debug string was written from
    /// where MOREDATA    = this is additional location data, using the form Class::Method when called within Tex.
    /// </summary>
    public class V2FormattedStringParser : FormattedStringParserBase {

        #region message format constants and regexes

        private const int V2COMMANDSTRINGLENGTH = 5;
        private const string V2MESSAGEPARSERREGEX = @"\[[0-9A-Za-z\.:<>`_]{0,}\]";
        private const string V2COMMANDIDENTIFIERREGEX = @"#[A-Z]{3,3}#";
        private const string IS_VALID_V2FORMATTEDSTRING_REGEX = @"\{\[[0-9A-Za-z\._]{0,}\]\[[0-9]{1,}\]\[[0-9]{1,}\]\[[0-9A-Za-z\._]{0,}\]\[[0-9A-Za-z\._]{0,}\]\[[0-9]{0,8}\]\[[0-9A-Za-z\.\:_<>`]{0,}\]\}\#[A-Z]{3,3}\#";

        #endregion

        private Regex groupMatchRegexCache;
        private Regex isValidRegexCache;

        protected override SingleOriginEvent TryParse(RawApplicationEvent rae) {
            if (rae == null) { return null; }

            if (IsValidV2FormattedString(rae.Text)) {
                SingleOriginEvent soe = new SingleOriginEvent(rae.Id);
                if (PopulateFromDebugString(rae.Text, soe)) {
                    return soe;
                }
            }
            return null;
        }

        public V2FormattedStringParser() {
            this.Name = RawEntryParserChain.V2_LINK;
        }

        #region private methods

        private bool IsValidV2FormattedString(string theString) {
            if ((theString == null) || (theString.Length == 0)) { return false; }
            if (!theString.StartsWith("{[")) { return false; }

            if (isValidRegexCache == null) {
                isValidRegexCache = new Regex(IS_VALID_V2FORMATTEDSTRING_REGEX, RegexOptions.Compiled);
            }

            return isValidRegexCache.IsMatch(theString);
        }

        private bool PopulateFromDebugString(string debugString, SingleOriginEvent output) {
            if (groupMatchRegexCache == null) {
                groupMatchRegexCache = new Regex(V2MESSAGEPARSERREGEX, RegexOptions.Compiled);
            }

            Match m = groupMatchRegexCache.Match(debugString);
            // This should return 5 matches for a legit debug string
            string machineName = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            string processId = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            if (this.IdentityProvider != null) {
                output.OriginIdentity = this.IdentityProvider.GetOriginIdentity(machineName, processId);
            }
            output.ThreadId = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            output.netThreadId = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            output.ModuleName = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            output.LineNumber = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            output.moreLocInfo = m.Captures[0].Value.Trim(new char[] { '[', ']' });

            // Now get the command type and turn it into an enum
            Match cmdMatch = Regex.Match(debugString, V2COMMANDIDENTIFIERREGEX);
            output.Type = ConvertCommandTypeToMessageType(cmdMatch.Captures[0].Value);

            // finally get the rest of the string as the debug message
            output.Text = debugString.Substring(cmdMatch.Index + V2COMMANDSTRINGLENGTH);  // commandstrlen currently 5
            return true;
        }

        #endregion
    }
}