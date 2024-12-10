using KNI_HR.Data_Transfer_Objects.User;
using Microsoft.AspNetCore.Mvc;

namespace KNI_HR.Controllers;

[ApiController]
[Route("/user")]
public class UserController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody]UserRegisterRequest request)
    {
        // TODO: create user in database through service, send verification email
        return new CreatedAtActionResult(nameof(Register), nameof(UserController), null, null);
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody]UserLoginRequest request)
    {
        // TODO: Database request through service, Validation of password, in case of correct password - generate token
        return Ok();
    }

    [HttpPost("verify/{token}")]
    public IActionResult VerifyEmail([FromRoute] string token)
    {

    }
}
