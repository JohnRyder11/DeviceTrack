namespace DeviceTracking.Entity.Models.Device
{
    public class CihazParca : BaseModel<int>
    {
        public int CihazId { get; set; }
        public Cihaz Cihaz { get; set; }
        public string Name { get; set; }
    }
}