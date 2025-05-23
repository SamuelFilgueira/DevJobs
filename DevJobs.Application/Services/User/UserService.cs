using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevJobs.Application.DTOs.User;
using DevJobs.Application.Interfaces.User;

namespace DevJobs.Application.Services.User;

public class UserService : IUserService
{
    public async Task<UserResponse> RegisterUserAsync(RegisterUserRequest request)
    {
        var response = new UserResponse();
        return response;
    }
}
