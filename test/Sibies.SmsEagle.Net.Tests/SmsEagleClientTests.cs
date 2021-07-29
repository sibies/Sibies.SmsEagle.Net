using System;
using System.Threading.Tasks;
using Xunit;

namespace Sibies.SmsEagle.Net.Tests
{
    public class SmsEagleClientTests
    {
        private readonly ISmsEagleClient _smsEagleClient;

        public SmsEagleClientTests()
        {
            var smsEagleConfig = new SmsEagleConfiguration("", "");
            _smsEagleClient = new SmsEagleClient(smsEagleConfig);
        }
        [Fact]
        public async Task SendSms_Test()
        {
            var result = await _smsEagleClient.SendSmsAsync("test", "1");
            Assert.True(result);
        }
    }
}
