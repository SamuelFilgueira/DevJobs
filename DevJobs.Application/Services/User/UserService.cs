using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevJobs.Application.DTOs.User;
using DevJobs.Application.Interfaces.User;
using DevJobs.Application.Validators.User;

namespace DevJobs.Application.Services.User;

public class UserService : IUserService
{
    public async Task<UserResponse> RegisterUserAsync(RegisterUserRequest request)
    {
       Validade(request);

        var response = new UserResponse();
        return response;
    }

    private void Validade(RegisterUserRequest request)
    {
        var validator = new RegisterUserValidator();
        var result = validator.Validate(request);

        if(result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage);
            throw new Exception(errorMessages.ToString());
        }
    }
}
