using DeviceTracking.Entity.Models.Device;

namespace DeviceTracking.Business.Servives.Abstract.Device
{
    public interface ICihazService
    {
        Cihaz CihazEkle(Cihaz cihaz);

        List<Cihaz> CihazList();
    }
}