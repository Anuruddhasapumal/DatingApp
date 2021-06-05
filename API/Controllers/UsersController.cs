using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public DataContext _context { get; }
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<AppUsers>> GetUsers()

        {
            var users = _context.Users.ToList();
            return users;

        }

        [HttpGet("{id}")]
        public ActionResult<AppUsers> GetUser(int id)

        {
            var user = _context.Users.Find(id);
            return user;

        }



    }





}