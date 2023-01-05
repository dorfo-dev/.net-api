using api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;


[Tags("Root")]
[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet(Name = "Root")]
    public HomeEntity Get()
    {
        return new HomeEntity
        {
            Date = DateTime.Now,
            Message = "Up"
        };
    }
    
}
