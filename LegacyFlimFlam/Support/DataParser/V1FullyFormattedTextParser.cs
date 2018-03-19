using Plisky.FlimFlam.Model;
using System.Text.RegularExpressions;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Support for the Legacy(V1) Text Parser.  V1 had an issue where procids and pids were limited to 5 characters therefore it was not compatible with
    /// 64 bit sources.  This has been totally replaced by v2 now.
    /// </summary>
    public class V1FullyFormattedTextParser : RawEntryParserChainLink {

        #region legacy message parsing code

        private const int COMMANDSTRINGLENGTH = 5;
        private const string V1_LEGACY_REGEX = @"\{\[[0-9A-Za-z\._]{0,}\]\[[0-9]{1,5}\]\[[0-9]{1,5}\]\[[0-9A-Za-z\. ]{0,}\]\[[0-9]{0,8}\]\}\#[A-Z]{3,3}\#";
        private static Regex v1RegexCache;

        internal static void ReturnStringBreakdown(string debugString, out string cmdType, out string ProcessID, out string MachineName, out string ThreadID,
        out string ModuleName, out string LineNumber, out string debugOutput) {
            ProcessID = null; MachineName = null; ThreadID = null; debugOutput = null;

            if (v1RegexCache == null) {
                v1RegexCache = new Regex(@"\[[0-9A-Za-z\.:_]{0,}\]", RegexOptions.Compiled);
            }

            Match m = v1RegexCache.Match(debugString);
            // This should return 5 matches for a legit debug string

            // TODO I believe this deletes string names where [] is passed as initial or final chars test and fix.

            // Get each of the location identifiers from the string. - removing the surrouding
            // [] delimiters from each of the values.
            MachineName = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            ProcessID = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            ThreadID = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            ModuleName = m.Captures[0].Value.Trim(new char[] { '[', ']' });
            m = m.NextMatch();
            LineNumber = m.Captures[0].Value.Trim(new char[] { '[', ']' });

            // Now get the command type and turn it into an enum
            Match cmdMatch = Regex.Match(debugString, "#[A-Z]{3,3}#");
            cmdType = cmdMatch.Captures[0].Value;

            // finally get the rest of the string as the debug message
            debugOutput = debugString.Substring(cmdMatch.Index + COMMANDSTRINGLENGTH);  // commandstrlen currently 5
        }

        #endregion

        internal static bool IsV1TextString(string theString) {
            if ((theString == null) || (theString.Length == 0)) { return false; }
            if (!theString.StartsWith("{[")) { return false; }

            if (v1RegexCache == null) {
                v1RegexCache = new Regex(V1_LEGACY_REGEX, RegexOptions.Compiled);
            }

            return v1RegexCache.IsMatch(theString);
        }

        protected override SingleOriginEvent TryParse(RawApplicationEvent rae) {
            if (IsV1TextString(rae.Text)) {
                var result = new SingleOriginEvent(rae.Id);
                return result;
            } else {
                return null;
            }
        }

        public V1FullyFormattedTextParser() {
            this.Name = RawEntryParserChain.LEG_LINK;
        }
    }
}