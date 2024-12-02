namespace DeviceTracking.Entity.DTO.Jwt
{
    public class AuthDTO
    {
        public Guid TransactionId { get; set; }
        public DateTime ExpireAt { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserId { get; set; }
    }
}