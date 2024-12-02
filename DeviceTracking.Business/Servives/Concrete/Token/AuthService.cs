using DeviceTracking.Business.Servives.Abstract.Token;
using DeviceTracking.Entity.DTO.Jwt;
using Jose;
using System.Text;

namespace DeviceTracking.Business.Servives.Concrete.Token
{
    public class AuthService : IAuthService
    {
        private readonly byte[] _jwtKey;
        private readonly JwsAlgorithm _jwtAlgorithm;

        public AuthService()
        {
            _jwtKey = Encoding.ASCII.GetBytes("IrWby**01");
            _jwtAlgorithm = JwsAlgorithm.HS256;
        }

        public string GetAuthToken(string userId)
        {
            AuthDTO authDTO = new AuthDTO()
            {
                CreateDate = DateTime.Now,
                ExpireAt = DateTime.Now.AddHours(4),
                TransactionId = Guid.NewGuid(),
                UserId = userId
            };

            var token = JWT.Encode(authDTO, _jwtKey, _jwtAlgorithm);

            return token;            
        }

        public string GetUser(string token)
        {
            var authDTO = JWT.Decode<AuthDTO>(token.Replace("KullaniciApi", ""), _jwtKey);
            if (authDTO == null)
            {
                throw new Exception("Auth Token bulunamadı");
            }
            if (authDTO.ExpireAt < DateTime.Now)
            {
                throw new Exception("Auth Token süresi doldu tekrar sisteme login olunuz");
            }

            return authDTO.UserId;
        }
    }
}