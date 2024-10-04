using FluentValidation;
using MonTue.Models;

namespace MonTue.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e=>e.eid).NotEmpty().WithMessage("Po ra pumka");

            RuleFor(e => e.ename).NotEmpty().WithMessage("String EEyu ra");

            RuleFor(e => e.salary).NotEmpty().WithMessage("Salary Odda");
        }
    }
}
