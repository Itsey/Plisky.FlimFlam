using System.Diagnostics;

namespace MexInternals {

    /// <summary>
    /// Used by the view support manager when trying to look up the resource instances for view. This class holds the data about each
    /// instance of alloating and deallocating a specific named resource.
    /// </summary>
    [DebuggerDisplay("DebugDisplay")]
    internal class ResourceTrackingInstance {

        public string DebugDisplay {
            get { return this.ToString(); }
        }

        public string Name;
        public long Value;
        public string SupportingData;
        public long GlobalIndex;
        public string MoreInfoData;
        public string Module;
        public string Line;
        public string Context;

        public ResourceTrackingInstance(string nm, long val, string ctxt, string moreLocation, string module, string line, long gidx) {
            Name = nm;
            Value = val;
            MoreInfoData = moreLocation;
            Module = module;
            Line = line;
            SupportingData = "in (" + moreLocation + ") at line " + line + " in \"" + module + "\"";
            GlobalIndex = gidx;
            Context = ctxt;
        }

        public ResourceTrackingInstance() {
            Name = string.Empty;
            SupportingData = string.Empty;
        }

        public override string ToString() {
            return Name + "=" + Value.ToString() + " @ " + Context;
        }
    }
}