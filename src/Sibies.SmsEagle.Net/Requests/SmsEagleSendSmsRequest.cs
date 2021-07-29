using System.Text.Json.Serialization;

namespace Sibies.SmsEagle.Net.Requests
{
    public class SmsEagleSendSmsRequest
    {
        [JsonPropertyName("method")]
        public string Method => "sms.send_sms";
        [JsonPropertyName("params")]
        public SmsEagleSendSmsParamsRequest Params { get; set; }
    }
}
