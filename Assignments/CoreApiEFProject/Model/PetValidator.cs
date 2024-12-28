using FluentValidation;

namespace CoreApiEFProject.Model
{
    public class PetValidator:AbstractValidator<PetAnimal>
    {
        public PetValidator()
        {
            RuleFor(pet => pet.petId)
                .GreaterThan(0).WithMessage("Pet ID must be greater than zero.");

            RuleFor(pet => pet.petName)
                .NotEmpty().WithMessage("Pet name is required.");

            RuleFor(pet => pet.petType)
                .MaximumLength(50).WithMessage("Pet type cannot exceed 50 characters.");

            RuleFor(pet => pet.petDob)
                .NotEmpty().WithMessage("Pet Dob is required.");

            RuleFor(pet => pet.petIsVeg)
                .NotNull().WithMessage("Pet vegetarian status cannot be null.");
        }
    }
}
