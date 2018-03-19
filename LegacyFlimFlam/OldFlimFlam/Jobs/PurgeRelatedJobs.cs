//using Plisky.Plumbing.Legacy;

namespace MexInternals {

    internal class Job_PurgeTracedAppByIndex : BaseJob {
        private int m_vindex;

        internal Job_PurgeTracedAppByIndex(int theVindex) {
            m_vindex = theVindex;
        }

        internal override string GetIdentifier() {
            return "Purge Job >> PurgeTracedAppByIndex";
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            requiresNotificationSuspense = true;
            return true;
        }

        internal override void ExecuteJob() {
            MexCore.TheCore.DataManager.PurgeKnownApplication(m_vindex);
            MexCore.TheCore.ViewManager.AddUserNotificationMessageByIndex(ViewSupportManager.UserMessages.PurgeJobCompletes, ViewSupportManager.UserMessageType.InformationMessage, null);
        }

        internal override void PerformPostJob() {
            MexCore.TheCore.ViewManager.ProcessChangeNotification(null);
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            return JobVerificationResults.None;
        }

        internal override bool CanPushBackUpStack() {
            return false;
        }
    } // End Job_PurgeTracedAppByIndex

    internal class Job_PurgeAllData : BaseJob {
        private int m_vIndexToExclude = -2;

        internal override string GetIdentifier() {
            return "Purge Job >> PurgeAllData";
        }

        internal Job_PurgeAllData() {
        }

        internal Job_PurgeAllData(int vIndexToExclude) {
           //Bilge.Assert(vIndexToExclude > -2, "Passing -2 or less to a virtual index is not a valid use of the exclusion parameter in PurgeAllData");

            m_vIndexToExclude = vIndexToExclude;
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            requiresNotificationSuspense = true;
            return true;
        }

        internal override void ExecuteJob() {
           //Bilge.Log("Mex::WorkManager >> Found PurgeAllData request, asking data manager to do it");

           //Bilge.Log("Purging Unknown Applications");
            MexCore.TheCore.DataManager.PurgeUnknownApplications();

           //Bilge.Log("Purging Known Appliactions");
            if (m_vIndexToExclude == -2) {
                MexCore.TheCore.DataManager.PurgeAllData();
            } else {
                MexCore.TheCore.DataManager.PurgeAllKnownApplicationsExceptThisOne(m_vIndexToExclude);
            }

            MexCore.TheCore.ViewManager.AddUserNotificationMessageByIndex(ViewSupportManager.UserMessages.PurgeJobCompletes, ViewSupportManager.UserMessageType.InformationMessage, null);
        }

        internal override void PerformPostJob() {
            MexCore.TheCore.ViewManager.ProcessChangeNotification(null);
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            return JobVerificationResults.None;
        }

        internal override bool CanPushBackUpStack() {
            return false;
        }
    } // End job_ACtivateODSGatherer.

    internal class Job_PurgeNonTracedApps : BaseJob {

        internal override string GetIdentifier() {
            return "Purge Job >> PurgeTracedAppByIndex";
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            requiresNotificationSuspense = true;
            return true;
        }

        internal override void ExecuteJob() {
           //Bilge.Log("Mex::WorkManager >> Found PurgeNonTracedApps request, asking data manager to do it");

            MexCore.TheCore.DataManager.PurgeUnknownApplications();
            MexCore.TheCore.ViewManager.AddUserNotificationMessageByIndex(ViewSupportManager.UserMessages.PurgeJobCompletes, ViewSupportManager.UserMessageType.InformationMessage, null);
        }

        internal override void PerformPostJob() {
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            return JobVerificationResults.None;
        }

        internal override bool CanPushBackUpStack() {
            return false;
        }
    } // End job_ACtivateODSGatherer.

    internal class Job_PartialPurgeApp : BaseJob {
        private int m_virtualIndexOfPurgerequest;

        internal Job_PartialPurgeApp(string machineName, int pid) {
            TracedApplication ta = MexCore.TheCore.DataManager.GetKnownApplicationByPid(pid, machineName);
           //Bilge.Assert(ta != null, "pid/machine name passed to Job_PartialPurge constructor do not map to a valid traced application.  This should not be possible");
            m_virtualIndexOfPurgerequest = ta.VirtualIndex;
        }

        internal Job_PartialPurgeApp(int virtualIndex) {
            m_virtualIndexOfPurgerequest = virtualIndex;
        }

        internal override string GetIdentifier() {
            return "Purge Job >> PurgeTracedAppByIndex";
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            requiresNotificationSuspense = true;
            return true;
        }

        internal override void ExecuteJob() {
           //Bilge.Log("Mex::WorkManager >> Found PartialPurgeAppByIndex request, asking the datamanager to do it");
            MexCore.TheCore.DataManager.PurgePartialKnownApplication(m_virtualIndexOfPurgerequest);
            MexCore.TheCore.ViewManager.AddUserNotificationMessageByIndex(ViewSupportManager.UserMessages.PurgeJobCompletes, ViewSupportManager.UserMessageType.InformationMessage, null);
        }

        internal override void PerformPostJob() {
            MexCore.TheCore.ViewManager.ProcessChangeNotification(m_virtualIndexOfPurgerequest);
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            return JobVerificationResults.None;
        }

        internal override bool CanPushBackUpStack() {
            return false;
        }
    } // End job_ACtivateODSGatherer.
}