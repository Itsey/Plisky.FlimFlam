using System;

namespace MexInternals {

    internal class TimeInstanceView {
        internal string SinkName;
        internal string InstanceName;
        internal DateTime EnterTime = DateTime.MaxValue;
        internal DateTime ExitTime = DateTime.MaxValue;

        internal TimeSpan Elaspsed {
            get {
                if (!this.Valid) {
                    return TimeSpan.MaxValue;
                }
                return ExitTime - EnterTime;
            }
        }

        internal bool Valid {
            get {
                return ((EnterTime != DateTime.MaxValue) && (ExitTime != DateTime.MaxValue));
            }
        }
    }
}