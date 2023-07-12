using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using SIBLEYBLAYOPERA.Services.UsersService;
using System.Net;
using System.Text;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>>GetAllUsers()
        {
            return await _usersService.GetAllUsers();
        }

        [HttpGet("GetSingleUserByFirstName/{FirstName}")]
        public async Task<ActionResult<Users>> GetSingleUserByFirstName(string firstname)
        {
            var result = await _usersService.GetSingleUserByFirstName(firstname);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByMiddleName/{MiddleName}")]
        public async Task<ActionResult<Users>>GetSingleUserByMiddleName(string middlename)
        {
            var result = await _usersService.GetSingleUserByMiddleName(middlename);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByLastName/{LastName}")]
        public async Task<ActionResult<Users>>GetSingleUserByLastName(string lastname)
        {
            var result = await _usersService.GetSingleUserByLastName(lastname);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByGender/{Gender}")]
        public async Task<ActionResult<Users>> GetSingleUserByGender(string gender)
        {
            var result = await _usersService.GetSingleUserByGender(gender);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByUserName/{UserName}")]
        public async Task<ActionResult<Users>> GetSingleUserByUserName(string username)
        {
            var result = await _usersService.GetSingleUserByUserName(username);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByPasswordHash/{PasswordHash}")]
        public async Task<ActionResult<Users>> GetSingleUserByPasswordHash(string passwordhash)
        {
            var result = await _usersService.GetSingleUserByPasswordHash(passwordhash);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Users>>>AddUser(Users user)
        {
            var result = await _usersService.AddUser(user);
            return Ok(result);
        }

        [HttpPut("UpdateUserByFirstName/{FirstName}")]
        public async Task<ActionResult<List<Users>>>UpdateUserByFirstName(string firstname, Users request)
        {
            var result = await _usersService.UpdateUserByFirstName(firstname, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByMiddleName/{MiddleName}")]
        public async Task<ActionResult<List<Users>>>UpdateUserByMiddleName(string middlename, Users request)
        {
            var result = await _usersService.UpdateUserByMiddleName(middlename, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByLastName/{LastName}")]
        public async Task<ActionResult<List<Users>>>UpdateUserByLastName(string lastname, Users request)
        {
            var result = await _usersService.UpdateUserByLastName(lastname, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByGender/{Gender}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByGender(string gender, Users request)
        {
            var result = await _usersService.UpdateUserByGender(gender, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByUserName/{UserName}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByUserName(string username, Users request)
        {
            var result = await _usersService.UpdateUserByUserName(username, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByPasswordHash/{PasswordHash}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByPasswordHash(string passwordhash, Users request)
        {
            var result = await _usersService.UpdateUserByPasswordHash(passwordhash, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByFirstName/{FirstName}")]
        public async Task<ActionResult<List<Users>>>DeleteUserByFirstName(string firstname)
        {
            var result = await _usersService.DeleteUserByFirstName(firstname);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByMiddleName/{MiddleName}")]
        public async Task<ActionResult<List<Users>>>DeleteUserByMiddleName(string middlename)
        {
            var result = await _usersService.DeleteUserByMiddleName(middlename);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByLastName/{LastName}")]
        public async Task<ActionResult<List<Users>>>DeleteUserByLastName(string lastname)
        {
            var result = await _usersService.DeleteUserByLastName(lastname);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByGender/{Gender}")]
        public async Task<ActionResult<List<Users>>>DeleteUserByGender(string gender)
        {
            var result = await _usersService.DeleteUserByGender(gender);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByUserName/{UserName}")]
        public async Task<ActionResult<List<Users>>>DeleteUserByUserName(string username)
        {
            var result = await _usersService.DeleteUserByUserName(username);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByPasswordHash/{PasswordHash}")]
        public async Task<ActionResult<List<Users>>> DeleteUserByPasswordHash(string passwordhash)
        {
            var result = await _usersService.DeleteUserByPasswordHash(passwordhash);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }
    }
}
