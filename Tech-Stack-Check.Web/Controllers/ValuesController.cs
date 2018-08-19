using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStackCheck.Web.Services;

namespace TechStackCheck.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValuesService valuesService;
        private readonly ILogger<ValuesController> logger;

        public ValuesController(IValuesService valuesService, ILogger<ValuesController> logger)
        {
            this.valuesService = valuesService;
            this.logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            logger.LogInformation("Get");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            logger.LogInformation($"Get {id}");
            return Ok(await valuesService.GetValue(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            logger.LogInformation("Post");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            logger.LogInformation("Post");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            logger.LogInformation("Delete");
        }
    }
}
