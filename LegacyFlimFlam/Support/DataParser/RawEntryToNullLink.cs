using Plisky.FlimFlam.Model;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Responsible for returning null for all instances of a raw entry that are passed.
    /// </summary>
    public class RawEntryToNullLink : RawEntryParserChainLink {

        protected override SingleOriginEvent TryParse(RawApplicationEvent rae) {
            return null;
        }

        // TODO : What is the point in this class? Does it serve any benefit.  Null indicates a failed parse so this will never parse.
        public RawEntryToNullLink() {
            this.Name = "N";
        }
    }
}