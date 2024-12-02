using DeviceTracking.Core.DataAccess.Concrete.EntityFramework;
using DeviceTracking.Dal.Abstract.Device.IRepositories;
using DeviceTracking.Entity.Models.Device;
using Microsoft.EntityFrameworkCore;

namespace DeviceTracking.Dal.Concrete.EntityFramework.Repositories.Device
{
    public class EfCihazDal : EfGenericRepository<Cihaz>, ICihazDal
    {
        public EfCihazDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}