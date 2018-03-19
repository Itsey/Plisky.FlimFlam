using Plisky.FlimFlam.Interfaces;
using Plisky.FlimFlam.Model;
using System;
using System.Collections.Generic;

namespace Plisky.FlimFlam {

    public class DataParser : IParseData {
        private RawEntryParserChain chain;
        private IOriginIdentityProvider originID;
        private IRecieveEvents outwardBound;

        public DataParser(IOriginIdentityProvider iop, RawEntryParserChain chn, IRecieveEvents reciever) {
            if (reciever == null) {
                throw new InvalidOperationException("The reciever can not be null, the DataParser can not parse entries into a null reciever");
            }
            outwardBound = reciever;
            chain = chn;
            originID = iop;
        }

        public void AddRawEvent(RawApplicationEvent rae) {
            VerifyChainExists();
            SingleOriginEvent soe = chain.Parse(rae);
            outwardBound.AddEvent(soe);
        }

        public void AddRawEvent(RawApplicationEvent[] rae) {
            VerifyChainExists();

            List<SingleOriginEvent> soe = new List<SingleOriginEvent>();
            foreach (var v in rae) {
                soe.Add(chain.Parse(v));
            }
            outwardBound.AddEvent(soe);
        }

        private void VerifyChainExists() {
            if (chain == null) {
                // TODO: Error handling.
                throw new InvalidOperationException("Invalid Use of the Data Parser, the chain needs to be completed before you can add things");
            }
        }

        public IRecieveEvents EventReciever {
            get {
                return outwardBound;
            }
            set {
                outwardBound = value;
            }
        }
    }
}