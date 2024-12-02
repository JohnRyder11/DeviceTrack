using DeviceTracking.Business.Servives.Abstract.Device;
using DeviceTracking.Dal.Abstract.Device.IRepositories;
using DeviceTracking.Entity.Models.Device;

namespace DeviceTracking.Business.Servives.Concrete.Device
{
    public class CihazService : ICihazService
    {
        private readonly ICihazDal _cihazDal;

        public CihazService(ICihazDal cihazDal)
        {
            _cihazDal = cihazDal;
        }


        public Cihaz CihazEkle(Cihaz cihaz)
        {
           return _cihazDal.Add(cihaz);
        }

        public List<Cihaz> CihazList()
        {
            return _cihazDal.GetAllList(x => x.Id == 1);
        }
    }
}