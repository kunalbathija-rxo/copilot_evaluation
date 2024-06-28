using Microsoft.AspNetCore.Mvc;
using Users.Backend.Api.Models;
using Users.Backend.Api.Services;

namespace Users.Backend.Api.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly IUserManager userManager;

        public UsersController(ILogger<UsersController> logger, IUserManager userManager)
        {
            logger = logger;
            userManager = userManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = userManager.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = userManager.GetUser(id);
            return Ok(user);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetUserDomain(int id)
        {
            var user = userManager.GetUserDomain(id);
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<User> CreateUser([FromBody] User newUser)
        {
            var createdUser = userManager.CreateUser(newUser);
            return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserEmailIfMissing(int id, [FromBody] User updatedUser)
        {
            var result = userManager.UpdateUserEmailIfMissing(id, updatedUser);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var result = userManager.DeleteUser(id);
            return NoContent();
        }

    }
}
