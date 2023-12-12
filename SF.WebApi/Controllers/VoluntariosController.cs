using Microsoft.AspNetCore.Mvc;
using SF.Core.Domain;
using SF_Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SF.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoluntariosController : ControllerBase
    {
        private readonly IVoluntarioManager voluntarioManager;

        public VoluntariosController(IVoluntarioManager voluntarioManager)
        {
            this.voluntarioManager = voluntarioManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await voluntarioManager.GetVoluntariosAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await voluntarioManager.GetVoluntariosAsync(id));
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
