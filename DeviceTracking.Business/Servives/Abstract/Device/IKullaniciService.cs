using DeviceTracking.Entity.Models.Device;

namespace DeviceTracking.Business.Servives.Abstract.Device
{
    public interface IKullaniciService
    {
        Kullanici GetKullanici(int Id);

        string Login(string username);
    }
}