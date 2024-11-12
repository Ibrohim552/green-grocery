using FluentValidation;

namespace FarmConnect.Application.Dto_s;

public readonly record struct FarmerBaseInfo(string Name, string Email,string Location);

public readonly record struct FarmerReadInfo
    (
        int Id,
        FarmerBaseInfo BaseInfo
        );
        public readonly record struct FarmerUpdateInfo
            (
                int Id,
                FarmerBaseInfo BaseInfo
                );
                
                public readonly record struct FarmerCreateInfo
                    (
                        FarmerBaseInfo BaseInfo
                        );

                public class FarmerValidator : AbstractValidator<FarmerBaseInfo>
                {
                    public FarmerValidator()
                    {
                        RuleFor(x => x.Name)
                           .NotEmpty().WithMessage("Name is necessarily");
                        RuleFor(x => x.Email)
                           .NotEmpty().WithMessage("Email is necessarily")
                           .EmailAddress().WithMessage("Email is not a valid email address");
                        RuleFor(x => x.Location)
                           .NotEmpty().WithMessage("Location is necessarily");
                    }
                }