using Microsoft.AspNetCore.Mvc;
using SF.Core.Domain;
using System.Collections.Generic;


namespace SF.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoluntariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Voluntario>()
            {
                new Voluntario(){ Id = 1, Nome = "Marina Lima", DtaNascimento = new System.DateTime(2020, 6,1)},
                new Voluntario(){ Id = 2, Nome = "Lara Matos", DtaNascimento = new System.DateTime(2020, 9,15)}
            });
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
