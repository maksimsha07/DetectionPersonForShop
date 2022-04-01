using DetectionPersonForShop.BLL;
using DetectionPersonForShop.BLL.EF;
using DetectionPersonForShop.DAL;
using DetectionPersonForShop.DAL.Entityes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DetectionPersonForShop.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        DataManager _datamanager;
        public UserController(DataManager dm)
        {
            _datamanager = dm;

        }

        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
        {
            bool test = _datamanager.Users.CreateUser(user);
            if (test == false) ModelState.AddModelError("Login", "Такой логин уже используется");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok();
        }
    }
}
