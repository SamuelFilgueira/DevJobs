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
}
