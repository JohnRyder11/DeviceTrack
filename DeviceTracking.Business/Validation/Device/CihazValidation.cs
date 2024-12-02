using DeviceTracking.Entity.Models.Device;
using FluentValidation;

namespace DeviceTracking.Business.Validation.Device
{
    public class CihazValidation : AbstractValidator<Cihaz>
    {
        public CihazValidation() 
        {
            RuleFor(u => u.Name).NotEmpty().WithErrorCode("84").WithMessage("İsim Girilmelidir!");            
            RuleFor(u => u.Name).MaximumLength(50).WithErrorCode("85").WithMessage("İsim alanı en fazla 50 karakter olmalıdır.");
        } 
    }
}