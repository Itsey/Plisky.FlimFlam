//using Plisky.Diagnostics;
using Plisky.FilmFlam.Interfaces;
using Plisky.FlimFlam.Interfaces;
using Plisky.FlimFlam.Model;
using System.Collections.Generic;

namespace Plisky.FilmFlam {

    /// <summary>
    /// Responsible for holidng references to all of the importers, quering them for data and providing that data to the data importer.
    /// </summary>
    public class ImportManager {
        //protected Bilge b;
        private object pendingEventsLock = new object();

        private Queue<RawApplicationEvent> pendingEvents = new Queue<RawApplicationEvent>();
        private List<ISupportImporting> activeImporters = new List<ISupportImporting>();
        private IParseData parser;

        public IEnumerable<RawApplicationEvent> EventsWaiting { get; set; }

        internal void AddImporter(ISupportImporting ism) {
            activeImporters.Add(ism);
        }

        public void Poll() {
            foreach (var v in activeImporters) {
                if (v.HasData) {
                    lock (pendingEventsLock) {
                        pendingEvents.Enqueue(v.GetNextEvent());
                    }
                }
            }
        }

        public void Process() {
            //b.Assert.True(parser != null, "Parser has not been established, unable to process");

            RawApplicationEvent rae = null;
            lock (pendingEvents) {
                if (pendingEvents.Count > 0) {
                    rae = pendingEvents.Dequeue();
                }
            }
            parser.AddRawEvent(rae);
        }

        public bool HasEventsWaiting {
            get {
                return pendingEvents.Count > 0;
            }
        }

        public ImportManager(IParseData p) {
            parser = p;
        }
    }
}