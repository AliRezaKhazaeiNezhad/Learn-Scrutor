using Microsoft.AspNetCore.Mvc;


namespace LegoLearn.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
       
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

    }
}
