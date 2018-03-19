using Plisky.FlimFlam.Model;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Responsible for implemeting a Parser link that accepts all input and creates a SingleOriginEvent from any RawApplication
    /// event which is passed to it.  This link accepts all data.
    /// </summary>
    public class AllowAllParserLink : RawEntryParserChainLink {

        protected override SingleOriginEvent TryParse(RawApplicationEvent rae) {
            if (string.IsNullOrEmpty(rae.Text)) {
                return null;
            }

            return new SingleOriginEvent(rae.Id) {
                //OriginSource = rae.Machine,
                //OriginIndex = rae.Process,
                Text = rae.Text
            };
        }

        public AllowAllParserLink() {
            this.Name = "A";
        }
    }
}