using Plisky.FlimFlam.Model;

namespace Plisky.FlimFlam.Interfaces {

    public interface IParseData {

        void AddRawEvent(RawApplicationEvent rae);

        void AddRawEvent(RawApplicationEvent[] rae);
    }
}