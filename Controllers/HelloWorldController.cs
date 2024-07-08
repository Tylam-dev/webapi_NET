using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HelloWorldController: ControllerBase
{
    IHelloWorldService helloWorldService;
    ILogger _logger;
    public HelloWorldController(ILogger<HelloWorldController> logger, IHelloWorldService helloWorldId)
    {
        _logger = logger;
        helloWorldService = helloWorldId;
    }
    
    public IActionResult Get()
    {
        _logger.LogInformation("Log de Hello World");
        return Ok(helloWorldService.GetHelloWorld());
    }
}