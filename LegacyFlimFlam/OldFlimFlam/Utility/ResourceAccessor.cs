using System;
using System.Configuration;
using System.Resources;

namespace MexInternals {

    internal class ResourceAccessor : IAppHelpAbstraction {

        #region IAppHelpAbstraction Members

        public string GetRawResourceString(string identifier) {
            ResourceManager rm = new ResourceManager("MexInternals.Resources.MexResources", this.GetType().Assembly);
            return rm.GetString(identifier);
        }

        public string GetAppBaseUrl() {
            string baseUrlFromConfig = ConfigurationManager.AppSettings["basehelpurl"];
            if (baseUrlFromConfig != null) {
                return baseUrlFromConfig;
            }
            throw new ConfigurationErrorsException("The application has not been configured correctly");
        }

        public bool ConsumeURL(string url) {
            throw new NotImplementedException();
        }

        public string GetAppUrl(string parameter) {
            string baseUrlFromConfig = ConfigurationManager.AppSettings["basehelpurl_1p"];
            if (baseUrlFromConfig != null) {
                return baseUrlFromConfig;
            }
            throw new ConfigurationErrorsException("The application has not been configured correctly");
        }

        #endregion
    }
}