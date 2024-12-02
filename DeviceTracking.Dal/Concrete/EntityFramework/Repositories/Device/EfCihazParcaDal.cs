using DeviceTracking.Core.DataAccess.Concrete.EntityFramework;
using DeviceTracking.Dal.Abstract.Device.IRepositories;
using DeviceTracking.Entity.Models.Device;
using Microsoft.EntityFrameworkCore;

namespace DeviceTracking.Dal.Concrete.EntityFramework.Repositories.Device
{
    public class EfCihazParcaDal : EfGenericRepository<CihazParca>, ICihazParcaDal
    {
        public EfCihazParcaDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}