using Plisky.FlimFlam.Model;
using System;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Provides validation that the events submitted are neither null or improperly formed such as having empty text elements
    /// then returns null for each of the possible entries passed.  Added into the chain to provide validation before the
    /// event is passed on to actual parsers.
    /// </summary>
    public class ValidatingNullProviderParserLink : RawEntryParserChainLink {

        protected override SingleOriginEvent TryParse(RawApplicationEvent rae) {
            if (rae == null) { throw new InvalidOperationException("The event to be parsed should never be null"); }

            if (string.IsNullOrEmpty(rae.Text)) {
                throw new InvalidOperationException("The event to be parsed should have more than zero text in its contents");
            }

            return null;
        }

        public ValidatingNullProviderParserLink() {
            this.Name = "F";
        }
    }
}