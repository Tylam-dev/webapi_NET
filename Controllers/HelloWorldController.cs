using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HelloWorldController: ControllerBase
{
    IHelloWorldService helloWorldService;
    public HelloWorldController(IHelloWorldService helloWorldId)
    {
        helloWorldService = helloWorldId;
    }

    public IActionResult Get()
    {
        return Ok(helloWorldService.GetHelloWorld());
    }
}