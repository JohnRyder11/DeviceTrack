using DeviceTracking.Core.DataAccess.Concrete.EntityFramework;
using DeviceTracking.Dal.Abstract.Device.IRepositories;
using DeviceTracking.Entity.Models.Device;
using Microsoft.EntityFrameworkCore;

namespace DeviceTracking.Dal.Concrete.EntityFramework.Repositories.Device
{
    public class EfKullaniciDal : EfGenericRepository<Kullanici>, IKullaniciDal
    {
        public EfKullaniciDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}