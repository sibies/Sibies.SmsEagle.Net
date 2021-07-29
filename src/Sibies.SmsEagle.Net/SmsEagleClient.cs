using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sibies.SmsEagle.Net.Constants;
using Sibies.SmsEagle.Net.Requests;

namespace Sibies.SmsEagle.Net
{
    /// <summary>
    /// https://www.smseagle.eu/api/
    /// </summary>
    public class SmsEagleClient : HttpClient, ISmsEagleClient
    {
        private readonly string _accessToken;
        public SmsEagleClient(SmsEagleConfiguration configuration)
        {
            BaseAddress = new Uri(configuration.UrlServer);
            _accessToken = configuration.AuthToken;
        }
        public async Task<bool> SendSmsAsync(string message, string phone)
        {
            var jsonRequest = JsonSerializer.Serialize(
                new SmsEagleSendSmsRequest
                {
                    Params = new SmsEagleSendSmsParamsRequest
                    {
                        AccessToken = _accessToken,
                        Message = message,
                        To = phone
                    }
                });
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await PostAsync(BaseAddress + ApiConstants.UrlSmsSendPath, content);
            return response.IsSuccessStatusCode;
        }
    }
}
