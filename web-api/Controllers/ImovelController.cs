using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        public readonly IImovelRepository repo;

        public ImovelController(IImovelRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(repo.Get(id));
        }

        [HttpPost("Set")]
        public IActionResult Set(Imovel model)
        {
            if (model != null)
            {
                repo.Set(model);
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Imovel model)
        {
            if (model != null)
            {
                repo.Delete(model);
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("Update")]
        public IActionResult Update(Imovel model)
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