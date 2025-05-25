using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevJobs.Application.DTOs.User;
using FluentValidation;

namespace DevJobs.Application.Validators.User;

public class RegisterUserValidator : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserValidator()
    {
        RuleFor(user => user.UserName).NotEmpty();
        RuleFor(user => user.Email).NotEmpty();
        RuleFor(user => user.Email).EmailAddress();
        RuleFor(user => user.Password.Length).GreaterThanOrEqualTo(6);

    }
}
