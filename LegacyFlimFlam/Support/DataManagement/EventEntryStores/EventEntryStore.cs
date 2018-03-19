namespace Plisky.FlimFlam {

    using System.Collections.Generic;

    /// <summary>
    /// Primary data store for the application, holds all of the data and the routes through it.
    /// </summary>
    public abstract class EventEntryStore {
        protected long currentCount = 0;

        protected abstract void ActualAddEntry(SingleOriginEvent ee);

        public abstract IEnumerable<SingleOriginEvent> GetEntries();

        protected virtual long ActualGetCount() {
            return currentCount;
        }

        public long Count {
            get { return ActualGetCount(); }
        }

        public void AddEntry(SingleOriginEvent ee) {
            currentCount++;
            ActualAddEntry(ee);
        }
    }
}