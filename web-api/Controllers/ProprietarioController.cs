using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProprietarioController : ControllerBase
    {
        public readonly IProprietarioRepository repo;

        public ProprietarioController(IProprietarioRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(repo.Get(id));
        }

        [HttpPost("Set")]
        public IActionResult Set(Proprietario model)
        {
            if (model != null)
            {
                repo.Set(model);
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Proprietario model)
        {
            if (model != null)
            {
                repo.Delete(model);
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("Update")]
        public IActionResult Update(Proprietario model)
        {
            if (model != null)
            {
                repo.Update(model);
                return Ok();
            }

            return BadRequest();
        }

    }
}