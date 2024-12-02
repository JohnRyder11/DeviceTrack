using DeviceTracking.Business.Servives.Abstract.Device;
using DeviceTracking.Entity.Models.Device;
using Microsoft.AspNetCore.Mvc;

namespace DeviceTracking.Api.Controllers.Device
{
    [Route("api/[controller]")]
    [ApiController]
    public class CihazController : ControllerBase
    {
        private readonly ICihazService _cihazService;
        private readonly IKullaniciService _kullaniciService;

        public CihazController(ICihazService cihazService, IKullaniciService kullaniciService)
        {
            _cihazService = cihazService;
            _kullaniciService = kullaniciService;
        }

        [HttpPost("cihaz-ekle")]
        public Cihaz CihazEkle(Cihaz input) 
        {
            return _cihazService.CihazEkle(input);
        }

        public List<Cihaz> CihazListesi() 
        {
            return _cihazService.CihazList();
        }

        [HttpGet("login/{userName}")]
        public string Login(string userName)
        {
            return _kullaniciService.Login(userName);
        }
    }
}