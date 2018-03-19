//using Plisky.Diagnostics;
using Plisky.FlimFlam.Interfaces;
using Plisky.FlimFlam.Model;
using System;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Responsible for owning the chain of parsers.
    /// </summary>
    public class RawEntryParserChain {
       // protected Bilge b;

        #region consts for links

        /// <summary>
        /// Represents the null parser link.
        /// </summary>
        public const string NULL_LINK = "N";

        /// <summary>
        /// Represents the Allow all link, this should probably be the last link in a chain
        /// </summary>
        public const string ALL_LINK = "A";

        /// <summary>
        /// Represents the validating link.  Should be first in the chain
        /// </summary>
        public const string VAL_LINK = "F";

        /// <summary>
        /// Represents the legacy link, this is old style messages
        /// </summary>
        public const string LEG_LINK = "L";

        /// <summary>
        /// Represents the V2 style messages (version 2 of the Bilge format)
        /// </summary>
        public const string V2_LINK = "T";

        #endregion

        private IOriginIdentityProvider identityProvider;

        private RawEntryParserChainLink ActiveChain;

        /// <summary>
        /// Create the chain by using static CreateChain method.
        /// </summary>
        private RawEntryParserChain(/*Bilge useThisTrace = null*/) {
            /*if (useThisTrace == null) {
                b = new Bilge(tl: System.Diagnostics.TraceLevel.Verbose);
            }*/
        }

        /// <summary>
        /// Quick way of returning a link by asking for it by a character.
        /// N - null entry parser.
        /// A - Allow all parser.
        /// F - Validating parser
        /// L - LegaccyFormat Parser
        /// T - FullyFormatted Parser
        /// </summary>
        /// <param name="c">The character represnenting the link to request</param>
        /// <returns></returns>
        private static RawEntryParserChainLink GetParserLinkByCharacterIdentity(char c, IOriginIdentityProvider oidp) {
            RawEntryParserChainLink result = null;
            if (c == NULL_LINK[0]) {
                result = new RawEntryToNullLink();
            } else if (c == ALL_LINK[0]) {
                result = new AllowAllParserLink();
            } else if (c == VAL_LINK[0]) {
                result = new ValidatingNullProviderParserLink();
            } else if (c == LEG_LINK[0]) {
                result = new V1FullyFormattedTextParser();
            } else if (c == V2_LINK[0]) {
                result = new V2FormattedStringParser();
            }
            if (result == null) {
                throw new ArgumentException("Unsupported parser link specified (" + c + ") is not in the known set NAFLT");
            }
            result.IdentityProvider = oidp;
            return result;
        }

        /// <summary>
        /// Creates a raw entry parser using an initialisation string to create thelinks.  Valid link names are:
        /// N (null) - A (all) - F (Validator) - L (LegacyV1) - T (FormattedV2).  Use RawEntryParserChain.CONSTNAME to get values.
        /// </summary>
        /// <param name="chainInitialisationString">The string to create the chain with</param>
        /// <param name="oidProvider">An identity provider</param>
        /// <returns>A valid raw entry parsing chain</returns>
        internal static RawEntryParserChain CreateChain(string chainInitialisationString, IOriginIdentityProvider oidProvider) {

            #region entry code

            if (string.IsNullOrEmpty(chainInitialisationString)) {
                throw new ArgumentException(chainInitialisationString, "The initialisation string passed to the Parser chain must specify at least one link.");
            }

            //Bilge b = new Bilge();
            //b.Assert.True(chainInitialisationString.IndexOf('F') <= 0, "When a filter is included in the chain it must be included as the first element in the chain.", "Actual " + chainInitialisationString + " \r\n Expected: F" + chainInitialisationString);

            #endregion

            RawEntryParserChain result = new RawEntryParserChain();
            RawEntryParserChainLink links = null;
            result.identityProvider = oidProvider;

            links = GetParserLinkByCharacterIdentity(chainInitialisationString[0], oidProvider);
            result.ActiveChain = links;

            for (int i = 1; i < chainInitialisationString.Length; i++) {
                links.SetLink(GetParserLinkByCharacterIdentity(chainInitialisationString[i], oidProvider));
                links = links.nextLink;
            }

            return result;
        }

        public SingleOriginEvent Parse(RawApplicationEvent rae) {

            #region entry code

            //b.Assert.True(ActiveChain != null, "The active chain must be completed before you are able to parse any entries");

            #endregion

            SingleOriginEvent result = ActiveChain.Parse(rae);

            // Fallback identity provider if the parser hasnt set it.
            if ((result != null) && (result.OriginIdentity < 0)) {
                result.OriginIdentity = identityProvider.GetOriginIdentity(rae.Machine, rae.Process);
            }
            return result;
        }

#if TESTACTIVE

        /// <summary>
        /// Used for testing only, returns the link to ensure that the correct links have been set up.
        /// </summary>
        /// <param name="offset">The number of links to visit (0 is the first)</param>
        /// <returns>The link at that position or null if none exists</returns>
        internal RawEntryParserChainLink TestGetLinkAtPosition(int offset) {
            RawEntryParserChainLink result = ActiveChain;
            while (offset > 0) {
                if (result != null) {
                    result = result.nextLink;
                    offset--;
                } else {
                    return null;
                }
            }
            return result;
        }

#endif
    }
}