using Plisky.FlimFlam.Interfaces;
using System.Collections.Generic;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Responsible for maintaining a mapping of the origin identities into single uint values that are the internal unique
    /// origin references.
    /// </summary>
    public class OriginIdentityStore : IOriginIdentityProvider {
        private Dictionary<int, OriginIdentity> existingOrigins = new Dictionary<int, OriginIdentity>();

        public int GetOriginIdentity(string sourceIdentity, string sourceIndex) {
            var origKey = OriginIdentity.ConvertIdentitiesToKey(sourceIdentity, sourceIndex);

            lock (existingOrigins) {
                foreach (var v in existingOrigins.Keys) {
                    if (existingOrigins[v].IdentifyingKey == origKey) {
                        return existingOrigins[v].Id;
                    }
                }
                OriginIdentity oi = new OriginIdentity(sourceIdentity, sourceIndex);
                existingOrigins.Add(oi.Id, oi);
                return oi.Id;
            }
        }

        private OriginIdentity ConvertIdentifiersToOriginIdentity(string source1, string source2) {
            return new OriginIdentity(source1, source2);
        }

        public bool ContainsIdentity(int selectedOriginIdentity) {
            // Must create a unit test that makes this method work.
            lock (existingOrigins) {
                return existingOrigins.ContainsKey(selectedOriginIdentity);
            }
        }
    }
}