using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    // Se inyecta la dependencia
    IHelloWorldService helloWorldService;

    TareasContext dbcontext;

    // Se recibe la Dependencia
    public HelloWorldController(IHelloWorldService helloWorld, TareasContext db)
    {
        helloWorldService = helloWorld;
        dbcontext = db;
    }

    [HttpGet]

    // Se utiliza el método GetHelloWorld
    public IActionResult Get()
    {
        return Ok(helloWorldService.GetHelloWorld());
    }

    [HttpGet]
    [Route("createdb")]
    public IActionResult CreateDatabase()
    {
        dbcontext.Database.EnsureCreated();

        return Ok();
    }
}