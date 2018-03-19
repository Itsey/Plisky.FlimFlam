using Plisky.FlimFlam.Interfaces;
using System;
using System.Collections.Generic;

namespace Plisky.FlimFlam {

    /// <summary>
    /// Responsible for creating the ActiveEventFilter, it holds all of the data required to determine how the filter should
    /// function in addition to the knowledge necessary to actually create the ActiveEventFilter.
    /// </summary>
    public class EventFilterFactory {
        private MessageType MessageTypeFlag;
        public bool CaseSensitive { get; set; }
        private List<int> IncludedProcesses { get; set; }

        //private List<string> ExcludedLocations { get; set; }
        //private List<string> ExcludedFilenames { get; set; }
        private List<string> IncludedMatchStrings { get; set; }

        private List<string> ExcludedMatchStrings { get; set; }
        private IOriginIdentityProvider processOriginSource { get; set; }

        public void IncludeProcess(int originUniqueId) {
            ValidateProcessId(originUniqueId);
            IncludedProcesses.Add(originUniqueId);
        }

        public void ExcludeProcess(int originSourceUniqueId) {
            if (!IncludedProcesses.Contains(originSourceUniqueId)) {
                throw new InvalidOperationException("The originSourceIdentity was not present in the list, therefore it could not be removed");
            }
            IncludedProcesses.Remove(originSourceUniqueId);
        }

        public void AddExclusionString(string textToExclude) {
            if (ExcludedMatchStrings == null) {
                ExcludedMatchStrings = new List<string>();
            }
            ExcludedMatchStrings.Add(textToExclude);
        }

        public void RemoveExclusionString(string textToExclude) {
            if (ExcludedMatchStrings != null) {
                if (ExcludedMatchStrings.Contains(textToExclude)) {
                    ExcludedMatchStrings.Remove(textToExclude);
                }
            }
            if (ExcludedMatchStrings.Count == 0) {
                ExcludedMatchStrings = null;
            }
        }

        public void AddInclusionString(string p) {
            if (IncludedMatchStrings == null) {
                IncludedMatchStrings = new List<string>();
            }
            IncludedMatchStrings.Add(p);
        }

        public void RemoveInclusionString(string p) {
            if ((IncludedMatchStrings != null) && (IncludedMatchStrings.Contains(p))) {
                IncludedMatchStrings.Remove(p);
                if (IncludedMatchStrings.Count == 0) {
                    IncludedMatchStrings = null;
                }
            } else {
                throw new InvalidOperationException("It is invalid to remove an inclusion string that is not in the list");
            }
        }

        internal ActiveEventFilter CreateActiveFilter() {
            if (this.IncludedProcesses.Count <= 0) {
                throw new InvalidOperationException("You are unable to create a filter where no processes are included");
            }

            ActiveEventFilter aef = new ActiveEventFilter(new ProcessFilterLink(IncludedProcesses));
            return aef;
        }

        public EventFilterFactory(IOriginIdentityProvider iop) {
            this.IncludedProcesses = new List<int>();
            processOriginSource = iop;
        }

        internal void SetProcess(int selectedOriginIdentity) {
            ValidateProcessId(selectedOriginIdentity);
            this.IncludedProcesses.Clear();
            IncludedProcesses.Add(selectedOriginIdentity);
        }

        private void ValidateProcessId(int selectedOriginIdentity) {
            if ((selectedOriginIdentity == 0) || (!processOriginSource.ContainsIdentity(selectedOriginIdentity))) {
                throw new InvalidOperationException("You must specify a valid process id");
            }
        }

        internal void IncludeMessageType(MessageType messageType) {
            this.MessageTypeFlag &= messageType;
        }

        internal void SetMessageType(MessageType testType) {
            throw new NotImplementedException();
        }
    }
}