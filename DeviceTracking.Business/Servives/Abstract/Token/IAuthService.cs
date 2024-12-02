namespace DeviceTracking.Business.Servives.Abstract.Token
{
    public interface IAuthService
    {
        string GetAuthToken(string userId);
        string GetUser(string token);
    }
}