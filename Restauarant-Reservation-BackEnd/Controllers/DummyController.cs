using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Restauarant_Reservation_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Working");
        }
    }
}
