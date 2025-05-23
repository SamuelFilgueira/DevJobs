using DevJobs.Application.DTOs.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevJobs.API.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Register(RegisterUserRequest request)
    {
        return Created();
    }
}
