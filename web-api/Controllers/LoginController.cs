using Domain.Entities;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly ILoginRepository repo;

        public LoginController(ILoginRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public IActionResult Login(string user, string senha)
        {
            var login = repo.Get(user, senha);
            if (login != null)
                return Ok(login);
            else
                return BadRequest();
        }

        [HttpPost]
        public IActionResult Set(Login login)
        {
            return Ok(repo.Set(login));
        }
    }
}
