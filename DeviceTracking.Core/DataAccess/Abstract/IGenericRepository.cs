namespace DeviceTracking.Core.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T Add(T entity);

        T GetFirstValue(Func<T, bool> filter);

        List<T> GetAllList(Func<T, bool> filter = null);
    }
}