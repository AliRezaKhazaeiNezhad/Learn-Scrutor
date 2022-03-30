using LegoLearn.Server.RepositoryServices;
using LegoLearn.Server.Services;
using Microsoft.AspNetCore.Mvc;


namespace LegoLearn.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController(IServiceOne serviceOne, ServiceTwo serviceTwo)
        {
            _serviceOne = serviceOne;
            _serviceTwo = serviceTwo;
        }

        public IServiceOne _serviceOne { get; set; }
        public ServiceTwo _serviceTwo { get; set; }


        [HttpGet]
        public string Get()
        {
            string message = "";

            message = _serviceOne.Print("This is message one");
            message = message + " | " + _serviceTwo.Print("This is message two");

            return message;
        }

    }
}
