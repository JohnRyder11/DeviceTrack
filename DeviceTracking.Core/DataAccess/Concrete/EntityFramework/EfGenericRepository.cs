using DeviceTracking.Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DeviceTracking.Core.DataAccess.Concrete.EntityFramework
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public EfGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T Add(T entity)
        {
            var t = _dbContext.Add<T>(entity);
            _dbContext.SaveChanges();

            return t.Entity;
        }

        public T GetFirstValue(Func<T, bool> filter)
        {
           return _dbSet.Where(filter).FirstOrDefault();
        }

        public List<T> GetAllList(Func<T, bool> filter = null)
        {
            if (filter != null)
            {
                return _dbSet.Where(filter).ToList();
            }

            return _dbSet.ToList();
        }        
    }
}