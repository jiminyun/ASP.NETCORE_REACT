namespace DOTNET_CORE_WEBAPI.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}