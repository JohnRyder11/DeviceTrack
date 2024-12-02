namespace DeviceTracking.Entity.Models.Device
{
    public class Kullanici : BaseModel<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AdSoyad { get; set; }
    }
}