using System;
using System.Threading;

namespace Plisky.FlimFlam.Model {

    /// <summary>
    /// RawApplicationEvent is responsible for holidng the data retrieved from the importers so that it can be passed to the data store.  RawApplicationEvents
    /// are transient and are replaced by OriginEvents once the datastore has finished importing the information.
    /// </summary>
    public class RawApplicationEvent {
        private static long masterEventEntryIndex = 0;

        public int OriginId { get; set; }

        public string Text { get; set; }
        public string Process { get; set; }
        public string Machine { get; set; }
        public DateTime ArrivalTime { get; set; }
        public long Id { get; private set; }

        public RawApplicationEvent() {
            Id = Interlocked.Increment(ref masterEventEntryIndex);
        }
    }
}