using Microsoft.AspNetCore.Mvc;

namespace FakeBooking.API.Controllers
{
    [Route("api/manualapi")]
    //[Controller]
    public class ManualAPI : Controller
    {
        // GET: api/<TestAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
