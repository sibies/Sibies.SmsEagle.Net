namespace Sibies.SmsEagle.Net
{
    public class SmsEagleConfiguration
    {
        public string UrlServer { get; }
        public string AuthToken { get; }

        public SmsEagleConfiguration(string urlServer, string authToken)
        {
            UrlServer = urlServer;
            AuthToken = authToken;
        }

    }
}
