//using Plisky.Plumbing.Legacy;
using System;

namespace MexInternals {

    internal interface IDiagnosticSupport {

        int GetDiagnosticStats();

        string GetDiagnosticGroup();

        bool GetDiagnosticByIndex(out string name, out string val);
    }

    /// <summary>
    /// Summary description for MexDiagnosticManager.
    /// </summary>
    internal class MexDiagnosticManager {

        internal MexDiagnosticManager() {
            //
            // TODO: Add constructor logic here
            //
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal void DumpInternalMessages() {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal void ShutDown() {
           //Bilge.Log("Mex::DiagnosticManager::Shutdown >> Mex Diagnostics Shutting down");
        }

        private string m_machineName;

        internal string ThisMachineName {
            get {
                if (m_machineName == null) {
                    m_machineName = Environment.MachineName;
                }
                return m_machineName;
            }
        } // end ThisMachineName
    }
}