using Microsoft.AspNetCore.Mvc;

namespace CoreMvcWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "temp";
        }
    }
}