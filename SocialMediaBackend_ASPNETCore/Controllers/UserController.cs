using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SocialMediaBackend_ASPNETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("Login")]
        public string Login(string Email, string Password)
        {
            return "";
        }
    }
}
