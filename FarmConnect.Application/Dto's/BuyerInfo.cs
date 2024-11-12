using FluentValidation;

namespace FarmConnect.Application.Dto_s;

public readonly record struct BuyerBaseInfo(string Name,string Email,string PhoneNumber);

public readonly record struct BuyerReadInfo
    (
        int Id,
        BuyerBaseInfo BaseInfo
        );
        
public readonly record struct BuyerUpdateInfo
    (
        int Id,
        BuyerBaseInfo BaseInfo
        );
        
        public readonly record struct BuyerCreateInfo
            (
                BuyerBaseInfo BaseInfo
                );



        public class BuyerValidator : AbstractValidator<BuyerBaseInfo>
        {
            public BuyerValidator()
            {
                RuleFor(x => x.Name)
                   .NotEmpty().WithMessage("Name is necessarily");
                RuleFor(x => x.Email)
                   .NotEmpty().WithMessage("Email is necessarily")
                   .EmailAddress().WithMessage("Email is not a valid email address");
                RuleFor(x => x.PhoneNumber)
                   .NotEmpty().WithMessage("Phone number is necessarily")
                   .Matches(@"^\d{10}$").WithMessage("Phone number must be 10 digits");
            }
        }
                
                