namespace MexInternals {

    internal interface IAppHelpAbstraction {

        string GetRawResourceString(string identifier);

        string GetAppBaseUrl();

        string GetAppUrl(string parameter);

        bool ConsumeURL(string url);
    }
}