using CRUD1.Data;
using CRUD1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IAllUsers AllUsers { get; set; }
        public UsersController(IAllUsers allUsers)
        {
            AllUsers = allUsers;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserInfo>>> GetAllUsers()
        {

            return Ok(AllUsers);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<UserInfo>> GetUser(string Id)
        {
            try
            {
                if (UserExists(Id))
                {
                    return Ok(User);
                }
                else
                {
                    return BadRequest("User was not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<ActionResult<UserInfo>> AddUser(UserInfo user)
        {
            var request = new UserInfo
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
            };
            AllUsers.userInfos.Add(request);
            if (UserExists(user.Id))
            {
                return Ok(AllUsers.userInfos);
            }
            else
            {
                return BadRequest("User was not added");
            }
        }
        private bool UserExists(string UserId) => AllUsers.userInfos.Any(x => x.Id == UserId);
    }
}

