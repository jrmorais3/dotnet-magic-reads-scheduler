using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadersController(ICustomerManager customerManager) : ControllerBase
    {
        private readonly ICustomerManager customerManager = customerManager;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await customerManager.GetCustomerAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await customerManager.GetCustomerAsync(id));
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
