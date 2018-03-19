using Plisky.FlimFlam;
using Plisky.FlimFlam.Interfaces;
using System;
using System.Collections.Generic;

namespace MexInternals {

    public class EventRecieverForComparisons : IRecieveEvents {
        private SingleOriginEvent lastEvent;

        public void AddEvent(SingleOriginEvent evt) {
            lastEvent = evt;
        }

        public void AddEvent(IEnumerable<SingleOriginEvent> evts) {
            throw new NotImplementedException();
        }

        internal bool Compare(EventEntry toThis) {
            bool result = true;
            if (lastEvent.LineNumber != toThis.LineNumber) {
                result = false;
            }
            if (lastEvent.ModuleName != toThis.Module) {
                result = false;
            }
            if (lastEvent.netThreadId != toThis.ThreadNetId) {
                result = false;
            }
            if (lastEvent.Text != toThis.DebugMessage) {
                result = false;
            }
            if ((int)lastEvent.Type != (int)toThis.cmdType) {
                result = false;
            }

            return result;
        }
    }
}