using DeviceTracking.Business.Servives.Abstract.Device;
using DeviceTracking.Business.Servives.Concrete.Token;
using DeviceTracking.Dal.Abstract.Device.IRepositories;
using DeviceTracking.Entity.Models.Device;

namespace DeviceTracking.Business.Servives.Concrete.Device
{
    public class KullaniciService : IKullaniciService
    {
        private readonly IKullaniciDal _kullaniciDal;
        public KullaniciService(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public Kullanici GetKullanici(int Id)
        {
           return _kullaniciDal.GetFirstValue(x => x.Id == Id);
        }

        public string Login(string username)
        {
            AuthService authService = new AuthService();
            return authService.GetAuthToken(username);
        }
    }
}