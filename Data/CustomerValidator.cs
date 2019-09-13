using FluentValidation;
namespace bikeservice.Data
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty().MaximumLength(10);
            RuleFor(customer => customer.Surname).NotEmpty().MaximumLength(10);
            RuleFor(customer => customer.Bike).SetValidator(new BikeValidator());

            RuleFor(customer => customer.Services).NotEmpty().WithMessage("You have to define at least one service");
            RuleForEach(customer => customer.Services).SetValidator(new ServiceValidator());
        }
    }

    public class BikeValidator : AbstractValidator<Bike>
    {
        public BikeValidator()
        {
            RuleFor(bike => bike.Model).NotEmpty();
            RuleFor(bike => bike.Year).NotEmpty().Matches("^[0-9]*$").WithMessage("Year must be number!");
            RuleFor(bike => bike.Serino).NotEmpty().MaximumLength(10);
        }
    }

    public class ServiceValidator : AbstractValidator<Service>
    {
        //https://fluentvalidation.net/built-in-validators (Full List)
        public ServiceValidator()
        {
            RuleFor(service => service.SeriNo)
                .NotEmpty().Matches("^[0-9]*$").WithMessage("Seri No must be number!")
                .When(service => service.ServiceType == Service.Type.OnikiBinBakım);            
        }
    }
}