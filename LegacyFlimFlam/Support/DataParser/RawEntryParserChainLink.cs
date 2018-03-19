using Plisky.FlimFlam.Interfaces;
using Plisky.FlimFlam.Model;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Responsible for describing each of the links in the chain, each link has the knowledge of how to parse a specific
    /// type of message.
    /// </summary>
    public abstract class RawEntryParserChainLink {
        internal IOriginIdentityProvider IdentityProvider { get; set; }
        internal string Name { get; set; }
        internal RawEntryParserChainLink nextLink;

        protected abstract SingleOriginEvent TryParse(RawApplicationEvent rae);

        public void SetLink(RawEntryParserChainLink next) {
            this.nextLink = next;
        }

        /// <summary>
        /// Calls each link in the chain attempting to create the event from the raw data.
        /// </summary>
        /// <param name="rae">The raw data</param>
        /// <returns>The formed single origin event</returns>
        public SingleOriginEvent Parse(RawApplicationEvent rae) {
            SingleOriginEvent result = TryParse(rae);
            if ((result == null) && (nextLink != null)) {
                result = nextLink.Parse(rae);
            }
            return result;
        }
    }
}