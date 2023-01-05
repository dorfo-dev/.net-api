using api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;


[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet(Name = "Home")]
    public HomeEntity Get()
    {
        return new HomeEntity
        {
            Date = DateTime.Now,
            Message = "Up"
        };
    }
}
