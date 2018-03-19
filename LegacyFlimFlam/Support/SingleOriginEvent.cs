using System.Diagnostics;

namespace Plisky.FlimFlam {

    [DebuggerDisplay("SOE: GIdx[ {Id} ]  OIdx[ {OriginIndex} ]")]
    public class SingleOriginEvent {
        public int OriginIdentity { get; set; }

        public string Text { get; set; }
        public long Id { get; private set; }

        public MessageType Type { get; set; }
        public string LineNumber { get; set; }
        public string netThreadId { get; set; }
        public string ThreadId { get; set; }
        public string moreLocInfo { get; set; }
        public string ModuleName { get; set; }

        public SingleOriginEvent(long entry) {
            OriginIdentity = -1;
            Id = entry;
        }
    }
}