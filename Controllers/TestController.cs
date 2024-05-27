using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
	[HttpGet("secure")]
	[Authorize]
	public IActionResult GetSecureData()
	{
		return Ok("Hello Cubic user, you are authenticated, authorized, and secured.");
	}

	[HttpGet("public")]
	public IActionResult GetPublicData()
	{
		return Ok("It's a public data no authentication required. So, it's not secured.");
	}
}
