using DeviceTracking.Core.Entity.Abstract;

namespace DeviceTracking.Entity.Models
{
    public class BaseModel<TId> : IEntity
    {
        public TId Id { get; set; }
    }
}