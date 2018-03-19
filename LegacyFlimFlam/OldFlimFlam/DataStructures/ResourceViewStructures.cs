namespace MexInternals {

    internal struct ValueIdxPair {
        internal long GlobalIndex;
        internal long Value;

        internal ValueIdxPair(long idx, long val) {
            GlobalIndex = idx;
            Value = val;
        }
    }

    internal struct ResourceProfile {
        internal string Name;
        internal ValueIdxPair[] Consumption;
        internal long HighestValue;
        internal long LowestValue;
    }
}