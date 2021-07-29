using System.Text.Json.Serialization;

namespace Sibies.SmsEagle.Net.Requests
{
    public class SmsEagleSendSmsParamsRequest
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        [JsonPropertyName("to")]
        public string To { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }

    }
}
