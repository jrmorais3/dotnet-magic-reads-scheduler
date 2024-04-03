using Microsoft.AspNetCore.Mvc;
using SF.Core.Domain;
using SF_Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerManager customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            this.customerManager = customerManager;
        }

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
