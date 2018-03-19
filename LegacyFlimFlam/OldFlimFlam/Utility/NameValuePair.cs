using System;

namespace MexInternals {

    /// <summary>
    /// Summary description for NameValuePair.
    /// </summary>
    public class NameValuePair {

        /// <summary>
        /// The name of the name value pair
        /// </summary>
        public string Name {
            get;
            set;
        }

        /// <summary>
        /// The value of the name value pair
        /// </summary>
        public long Value {
            get;
            set;
        }

        /// <summary>
        /// Creates an empty name value pair
        /// </summary>
        public NameValuePair() {
            Name = String.Empty;
        }

        /// <summary>
        /// Creates a name value pair and initialises to the values
        /// </summary>
        /// <param name="nameVal">The name part of the name value pair</param>
        /// <param name="valVal">The value part of the name value pair</param>
        public NameValuePair(string name, long value) {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Initialises the name value pair using a string format of name=value.  This parses this string into the class.
        /// </summary>
        /// <param name="aNameEqValPairString"></param>
        public NameValuePair(string nameEqualsValuePairData)
            : this() {
            int i = nameEqualsValuePairData.IndexOf('=');
            if (i >= 0) {
                Name = nameEqualsValuePairData.Substring(0, i - 1);
                Value = long.Parse(nameEqualsValuePairData.Substring(i + 1));
            }
        }

        /// <summary>
        /// Converts the name value pair into a string
        /// </summary>
        /// <returns>A string concatinating the name = value</returns>
        public override string ToString() {
            return Name + "=" + Value.ToString();
        }
    }
}