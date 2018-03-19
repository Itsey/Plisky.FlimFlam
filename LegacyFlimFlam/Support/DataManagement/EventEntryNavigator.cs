namespace Plisky.FlimFlam {

    public class EventEntryNavigator {
        public EventEntryStoredElement Next { get; set; }
        public EventEntryStoredElement Previous { get; set; }

        public EventEntryNavigator(EventEntryStoredElement next, EventEntryStoredElement previous) {
            this.Next = next;
            this.Previous = previous;
        }
    }
}