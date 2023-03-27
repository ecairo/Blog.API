using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/heartbeat")]
    [ApiController]
    public class HeartBeatController : ControllerBase
    {
        [HttpGet]
        public string Beating()
        {
            return DateTime.Now.ToString();
        }
    }
}
