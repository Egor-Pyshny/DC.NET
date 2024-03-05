using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Services.DataProviderServices;
using RV.Services.DataProviderServices.SQL;
using RV.Views.DTO;

namespace RV.Controllers
{
    [Route("api/v1.0/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDataProvider _context;

        public UsersController(IDataProvider context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<UserDTO> GetUsers()
        {
            return _context.GetUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public UserDTO GetUser(int id)
        {
            //_context.GetUsers();
            /*var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;*/
            return null;
        }

        // PUT: api/Users/5
        [HttpPut]
        public UserDTO PutUser([FromBody]UserAddDTO user)
        {
            /*if (id != user.id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();*/

            return null;
        }

        // POST: api/Users
        [HttpPost]
        public UserDTO PostUser([FromBody]UserAddDTO user)
        {
            return _context.CreateUser(user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            /*var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();*/

        }
    }
}
