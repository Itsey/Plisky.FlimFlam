namespace Plisky.FlimFlam {

    public class EventEntryStoredElement {
        public SingleOriginEvent Entry { get; set; }
        public EventEntryNavigator Navigation { get; set; }

        public EventEntryStoredElement(SingleOriginEvent ee, EventEntryStoredElement next, EventEntryStoredElement previous) {
            this.Navigation = new EventEntryNavigator(next, previous);
            Entry = ee;
        }
    }
}