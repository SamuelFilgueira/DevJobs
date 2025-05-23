using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevJobs.Application.DTOs.User;

namespace DevJobs.Application.Interfaces.User;

public interface IUserService
{
    public Task<UserResponse> RegisterUserAsync(RegisterUserRequest request);
}
