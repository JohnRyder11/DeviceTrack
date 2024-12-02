using System.Net;

namespace DeviceTracking.Api.Middleware
{
    public class RequestLog
    {
        private RequestDelegate _next;

        public RequestLog(RequestDelegate next)
        {
            _next = next;            
        }

        public async Task InvokeAsync(HttpContext httpContext) 
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = GetResponseStatusCode(ex);
                string errorCode = "";
                string message = ex.Message;


                byte[] data = System.Text.Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(message));

                await httpContext.Response.Body.WriteAsync(data, 0, data.Length);
            }
            
        }

        private int GetResponseStatusCode(Exception e)
        {
            int statusCode = (int)HttpStatusCode.InternalServerError;           

            return statusCode;
        }

    }
}
