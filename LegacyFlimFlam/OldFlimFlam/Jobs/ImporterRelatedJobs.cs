//using Plisky.Plumbing.Legacy;
using System.IO;

namespace MexInternals {

    internal class Job_ActivateODSGatherer : BaseJob {
        private bool m_activatethegatherer;

        internal Job_ActivateODSGatherer(bool activate) {
            m_activatethegatherer = activate;
        }

        internal override string GetIdentifier() {
            return "Activate ODS Gatherer Job";
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            requiresNotificationSuspense = false;
            return true;
        }

        internal override void ExecuteJob() {
           //Bilge.Log("Mex::WorkManager >> Found ActivateODS Gatherer request, asking MessageManager to activate ODS capture");
            if (m_activatethegatherer) {
                MexCore.TheCore.MessageManager.ActivateODSGatherer();
            } else {
                MexCore.TheCore.MessageManager.DeactivateODSGatherer();
            }
        }

        internal override void PerformPostJob() {
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            Job_ActivateODSGatherer alt = alternative as Job_ActivateODSGatherer;
            if (alt == null) { return JobVerificationResults.None; }   // No impact.

            // Essentially if there is another one which is the same then remove the other one, if its different then remove this one, as there
            // is no point turning it on then immediately off etc.
            if (alt.m_activatethegatherer == m_activatethegatherer) {
                return JobVerificationResults.CurrentJobRendersFutureJobRedundant;
            } else {
                return JobVerificationResults.FutureJobRendersCurrentJobRedundant;
            }
        }

        internal override bool CanPushBackUpStack() {
            // There would be no point in delaying this request
            return false;
        }
    } // End job_ACtivateODSGatherer.

    internal class Job_ChangeTCPGathererState : BaseJob {
        private bool m_changeStateToActivate;

        internal Job_ChangeTCPGathererState(bool activate) {
            m_changeStateToActivate = activate;
        }

        internal override string GetIdentifier() {
            return "ChangeTCPGatherer State Job";
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            requiresNotificationSuspense = false;
            return true;
        }

        internal override void ExecuteJob() {
           //Bilge.Log("Executing job Job_ChangeTCPGathererState", "Bringing the gatherer " + (m_changeStateToActivate ? "Online" : "Offline"));

            if (m_changeStateToActivate) {
                MexCore.TheCore.MessageManager.ActivateTCPGatherer();
            } else {
                MexCore.TheCore.MessageManager.DeactivateTCPGatherer();
            }
        }

        internal override void PerformPostJob() {
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            Job_ChangeTCPGathererState alt = alternative as Job_ChangeTCPGathererState;
            if (alt == null) { return JobVerificationResults.None; }

            if (alt.m_changeStateToActivate == m_changeStateToActivate) {
                return JobVerificationResults.CurrentJobRendersFutureJobRedundant;
            } else {
                return JobVerificationResults.FutureJobRendersCurrentJobRedundant;
            }
        }

        internal override bool CanPushBackUpStack() {
            // There would be no point in delaying this request
            return false;
        }
    } // End Job_ActivateTCPGatherer

    internal class Job_LoadTraceFile : BaseJob {
        private string m_fileName;
        private FileImportMethod m_useThisImportMethod;
        private bool m_initialised;
        internal string AssignIdentToProcess;

        internal Job_LoadTraceFile(string filename, FileImportMethod fmo) {
            m_fileName = filename;
            m_useThisImportMethod = fmo;

            m_initialised = true;
        }

        internal override string GetIdentifier() {
            return "LoadTraceFile job";
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            requiresNotificationSuspense = true;

           //Bilge.Assert(m_fileName != null, "Filename cant be null for the loadfromfile job being pulled from joq queue");
           //Bilge.Assert(File.Exists(m_fileName), "Filename does not exist, loadfromfile job cannot perfor on an empty file");

            if (!File.Exists(m_fileName)) { m_initialised = false; }

            return m_initialised;
        }

        internal override void ExecuteJob() {
           //Bilge.Log("Mex::WorkManager >> Found LoadFile Request, asking MessageManager to load file");
            MexCore.TheCore.MessageManager.LoadMessagesFromFile(m_fileName, m_useThisImportMethod);
        }

        internal override void PerformPostJob() {
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            return JobVerificationResults.None;
        }

        internal override bool CanPushBackUpStack() {
            return true;
        }
    } // End job_ACtivateODSGatherer.
}