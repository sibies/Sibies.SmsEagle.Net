using System.Threading.Tasks;

namespace Sibies.SmsEagle.Net
{
    public interface ISmsEagleClient
    {
        Task<bool> SendSmsAsync(string message, string phone);
    }
}
