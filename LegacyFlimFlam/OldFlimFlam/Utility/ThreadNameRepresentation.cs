using System;
using System.Collections.Generic;

namespace MexInternals {

    public class KeyDisplayRepresentation : IEquatable<KeyDisplayRepresentation>, IEquatable<string> {

        public static bool ContainsKey(List<KeyDisplayRepresentation> keyDisplayRepresentation, string key) {
            foreach (KeyDisplayRepresentation k in keyDisplayRepresentation) {
                if (k.KeyIdentity == key) {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsName(List<KeyDisplayRepresentation> keyDisplayRepresentation, string name) {
            foreach (KeyDisplayRepresentation k in keyDisplayRepresentation) {
                if (k.DisplayIdentity == name) {
                    return true;
                }
            }
            return false;
        }

        private string m_keyId;
        private string m_dispId;

        public string KeyIdentity {
            get { return m_keyId; }
            set { m_keyId = value; }
        }

        public string DisplayIdentity {
            get { return m_dispId; }
            set { m_dispId = value; }
        }

        public KeyDisplayRepresentation(string key, string display) {
            KeyIdentity = key;
            DisplayIdentity = display;
        }

        public KeyDisplayRepresentation() {
            m_dispId = m_keyId = string.Empty;
        }

        public override string ToString() {
            return DisplayIdentity;
        }

        #region IEquatable<KeyDisplayRepresentation> Members

        bool IEquatable<KeyDisplayRepresentation>.Equals(KeyDisplayRepresentation other) {
            if (other == null) { return false; }
            return (this.KeyIdentity == other.KeyIdentity);
        }

        #endregion

        #region IEquatable<string> Members

        bool IEquatable<string>.Equals(string other) {
            if (other == null) { return false; }
            return (this.KeyIdentity == other);
        }

        #endregion
    }
}