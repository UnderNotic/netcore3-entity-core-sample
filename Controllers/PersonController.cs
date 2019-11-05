using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ef101.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/{name}")]
        public IActionResult Get(string name)
        {
            using (var ctx = new PersonContext())
            {
                ctx.Add(new PersonEntity { Name = "Person1", Age = 10 });
                ctx.SaveChanges();
            }

            return Ok();

        }
    }
}
