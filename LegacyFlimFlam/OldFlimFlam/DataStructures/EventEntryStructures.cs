using Plisky.Plumbing;
using System;
using System.Diagnostics;

namespace MexInternals {

    /// <summary>
    /// Each processes debug output consists of a series of event entries.  These event entries are what make up the growing logs
    /// from the program.  Each event entry is stored in its own class - although much of the information is stripped and only the
    /// event entry specific stuff remains - such as the thread ID
    /// </summary>
    [DebuggerDisplay("{m_vsnetdbgvw}")]
    internal class EventEntry {
        internal SupportingMessageData SupportingData;
        internal TraceCommandTypes cmdType;  // The type of this event
        internal string Module;
        internal string LineNumber;
        internal string SecondaryMessage; // The more info part of the message
        internal string ThreadID;       // OS ID of thread that caused message
        internal string ThreadNetId;  // .net ID of the thread that caused the message
        internal string MoreLocationData; // Additional location data sent
        internal long GlobalIndex;    // Globally assigned index.
        internal bool HasMoreInfo;
        internal uint LastVisitedFilter;        // Filters dont change much, this is the id of the last filter used
        internal bool LastVisitedFilterResult;  // This is the result of that last filters visit and will be used again if filter.idx==lastvisitedfilter
        internal ViewSpecificData ViewData;  // This is used by the views to store info such as highlighting and find matches.
        internal DateTime m_timeMessageRecieved;  // The time that Mex recieved the message

        internal static EventEntry CreatePseudoEE(long newGlobalIndex, string debugMessage) {
            EventEntry result = new EventEntry(newGlobalIndex, "Unknown", "00", "-1", debugMessage, "XRef::PidMatch", string.Empty);
            result.cmdType = TraceCommandTypes.LogMessage;
            result.ViewData.isValid = false;
            return result;
        }

        internal string GetDiagnosticStringData() {
            string result = "Event Entry: \r\n" + " Msg(" + DebugMessage + ")\r\n";
            result += "Index : " + GlobalIndex + "\r\n";
            return result;
        }

        private string m_vsnetdbgvw {
            get { return cmdType.ToString() + " idx : " + GlobalIndex.ToString(); }
        }

        internal void SetDebugMessage(string msg) {
            int markerPoint = msg.IndexOf("~~#~~");

            if (markerPoint >= 0) {
                // This debug message has attached to it a secondary message.
                SecondaryMessage = msg.Substring(markerPoint + 5);
                DebugMessage = msg.Substring(0, markerPoint);
            } else {
                DebugMessage = msg;
                SecondaryMessage = string.Empty;
            }
        }

        internal string DebugMessage;

        internal string CurrentThreadKey {
            get {
                return this.ThreadNetId + "_" + this.ThreadID;
            }
        }

        /// <summary>
        /// Determines if this event entry and the one passed contain the same physical data.
        /// </summary>
        /// <remarks> This ignores times and global indexes</remarks>
        /// <param name="obj">An event entry to compare against</param>
        /// <returns>True if the data is the same</returns>
        public override bool Equals(object obj) {
            if ((obj.GetType() != typeof(EventEntry))) {
                throw new InvalidCastException("You can not compare an EventEntry with anything that is not an EventEntry");
            }
            EventEntry ee = (EventEntry)obj;

            bool result = true;

            if (this.DebugMessage != ee.DebugMessage) {
                result = false;
            }
            if (this.cmdType != ee.cmdType) {
                result = false;
            }
            if (this.CurrentThreadKey != ee.CurrentThreadKey) {
                result = false;
            }
            if ((this.LineNumber != ee.LineNumber) || (this.Module != ee.Module) || (this.MoreLocationData != ee.MoreLocationData)) {
                result = false;
            }
            if (this.SecondaryMessage != ee.SecondaryMessage) {
                result = false;
            }
            return result;
        }

        internal EventEntry(long gIndex) {
            GlobalIndex = gIndex;
        }

        internal EventEntry(EventEntry copyMe) {
            this.cmdType = copyMe.cmdType;
            this.DebugMessage = copyMe.DebugMessage;
            this.HasMoreInfo = copyMe.HasMoreInfo;
            this.LastVisitedFilter = copyMe.LastVisitedFilter;
            this.LastVisitedFilterResult = copyMe.LastVisitedFilterResult;
            this.LineNumber = copyMe.LineNumber;
            this.Module = copyMe.Module;
            this.MoreLocationData = copyMe.MoreLocationData;
            this.SecondaryMessage = copyMe.SecondaryMessage;
            this.ThreadID = copyMe.ThreadID;
            this.ThreadNetId = copyMe.ThreadNetId;
            this.ViewData = new ViewSpecificData();
        }

        internal EventEntry(long newGlobalIndex, string newModule, string newLineNo, string newThreadId, string newDebugMessage, string moreLocData, string threadnetidentity)
            : this(newGlobalIndex) {
            GlobalIndex = newGlobalIndex;
            ThreadID = newThreadId;
            DebugMessage = newDebugMessage;
            MoreLocationData = moreLocData;
            ThreadNetId = threadnetidentity;
            Module = newModule;
            LineNumber = newLineNo;
            cmdType = TraceCommandTypes.Unknown;
            ViewData.isValid = false;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    } // end EventEntry class def
}