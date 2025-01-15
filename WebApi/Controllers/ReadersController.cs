using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadersController(IReaderManager ReaderManager) : ControllerBase
    {
        private readonly IReaderManager ReaderManager = ReaderManager;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await ReaderManager.GetReaderAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await ReaderManager.GetReaderAsync(id));
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
