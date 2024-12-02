using DeviceTracking.Business.Servives.Abstract.Device;
using DeviceTracking.Business.Servives.Abstract.Token;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DeviceTracking.Api.Middleware
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var token = context.HttpContext.Request.Headers["Token"].FirstOrDefault();
            
            if (!string.IsNullOrEmpty(token))
            {
                IAuthService _authService = (IAuthService)context.HttpContext.RequestServices.GetService(typeof(IAuthService));
                if (_authService != null) 
                {
                    string userId = _authService.GetUser(token);

                    if (userId != null)
                    {
                        IKullaniciService _kullaniciService = (IKullaniciService)context.HttpContext.RequestServices.GetService(typeof(IKullaniciService));
                        var kullanici = _kullaniciService.GetKullanici(Convert.ToInt32(userId));
                    }
                }             
            }
        }
    }
}