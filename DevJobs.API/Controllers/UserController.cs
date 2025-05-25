using System.Threading.Tasks;
using DevJobs.Application.DTOs.User;
using DevJobs.Application.Interfaces.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevJobs.API.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Register(RegisterUserRequest request)
    {
        var newUser = await _userService.RegisterUserAsync(request);
        return Created();
    }
}
