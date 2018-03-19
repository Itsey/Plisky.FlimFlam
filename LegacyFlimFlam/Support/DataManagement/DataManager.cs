namespace Plisky.FlimFlam {

    using Plisky.FlimFlam.Interfaces;
    using System;
    using System.Collections.Generic;

    public class DataManager : IRecieveEvents {
        private IMakeEventEntryStores factory;
        private EventEntryStore primary;

        public DataManager(IMakeEventEntryStores eesf) {
            factory = eesf;
            primary = eesf.GetNewEventEntryStore();
        }

        public EventEntryStore GetEventEntries(IFilterProvider filter) {
            if (filter == null) {
                // TODO: Exception Handling
                throw new InvalidOperationException("DEV - a filter must be provided");
            }
            var ees = factory.GetNewEventEntryStore();
            foreach (var v in primary.GetEntries()) {
                if (filter.IncludeEvent(v)) {
                    ees.AddEntry(v);
                }
            }
            return ees;
        }

        #region IRecieveEvents Members

        public void AddEvent(SingleOriginEvent soe) {
            primary.AddEntry(soe);
        }

        public void AddEvent(IEnumerable<SingleOriginEvent> soe) {
            foreach (var e in soe) {
                primary.AddEntry(e);
            }
        }

        #endregion

        internal EventViewProvider GetEventViewProvider(IFilterProvider ifp) {
            var ee = new EventEntryStoreFactory().GetNewEventEntryStore();
            foreach (var v in primary.GetEntries()) {
                if (ifp.IncludeEvent(v)) {
                    ee.AddEntry(v);
                }
            }
            return new EventViewProvider(ee);
        }

        internal SingleOriginEvent GetEntryByOffset(int i) {
            throw new NotImplementedException();
        }
    }
}