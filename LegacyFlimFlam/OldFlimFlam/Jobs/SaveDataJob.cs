using System;

namespace MexInternals.Mex.Jobs {

    internal class SaveAllDataJob : BaseJob {

        internal override string GetIdentifier() {
            return "Save Job >> Save All Data Job";
        }

        internal override bool InitialiseJob(out bool requiresNotificationSuspense) {
            throw new NotImplementedException();
        }

        internal override void ExecuteJob() {
            throw new NotImplementedException();
        }

        internal override void PerformPostJob() {
            throw new NotImplementedException();
        }

        internal override JobVerificationResults VerifyOtherJobsOnStack(BaseJob alternative) {
            if (alternative.GetIdentifier() == this.GetIdentifier()) {
                return JobVerificationResults.FutureJobRendersCurrentJobRedundant;
            }
            return JobVerificationResults.None;
        }

        internal override bool CanPushBackUpStack() {
            throw new NotImplementedException();
        }
    }
}