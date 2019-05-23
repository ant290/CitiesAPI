namespace CityInfo.API.Services
{
    public interface IMailService
    {
        /// <summary>
        /// this mocks sending a mail and instead writes to debug window
        /// </summary>
        void Send(string subject, string message);
    }
}