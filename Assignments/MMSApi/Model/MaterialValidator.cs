using FluentValidation;

namespace MMSApi.Model
{
    public class MaterialValidator:AbstractValidator<Material>
    {
        public MaterialValidator() {
            RuleFor(material => material.mId)
               .GreaterThan(0).WithMessage("Material ID must be greater than zero.");

            RuleFor(material => material.mName)
                .NotEmpty().WithMessage("Material name is required.");
            RuleFor(material => material.mType)
              .NotEmpty().WithMessage("Material type name is required.");

            RuleFor(material=> material.mQuantity)
               .GreaterThan(0).WithMessage("Material Quantity must be greater than zero.");

            RuleFor(material=>material.mRetailer)
                .NotEmpty().WithMessage("Retailer name is Required.");

        }
    }
}

