using LegoLearn.Server.Services;
using Microsoft.AspNetCore.Mvc;


namespace LegoLearn.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        public Home(IServiceOne serviceOne)
        {
            _serviceOne = serviceOne;
        }

        public IServiceOne _serviceOne { get; set; }


        [HttpGet]
        public string Get()
        {
            return _serviceOne.Print();
        }

    }
}
