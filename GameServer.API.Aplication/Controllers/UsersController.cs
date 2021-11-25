using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameServer.API.Domain.Dtos.User;
using GameServer.API.Domain.Interfaces.Services.User;
using Swashbuckle.AspNetCore.Annotations;
using GameServer.API.Domain.Dtos.ListModel;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameServer.API.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Descrição de teste")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService _service)
        {
            this._service = _service;
        }
        // GET: api/<UsersController>
        // GET api/<UsersController>/5

        /// <summary>
        /// Lista os usuários.
        /// </summary>
        /// <returns>Os usuários</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        /// 
        [Authorize("Bearer")]
        [HttpGet("getAll/{skip}/{take}")]
        public async Task<ActionResult<ListModel<UserDto>>> GetAll(int skip, int take)
        {
            try
            {
                return Ok(await _service.GetAll(skip, take));
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }
        
        [Authorize("Bearer")]
        [HttpGet("get/{userId}")]
        public async Task<ActionResult<UserDto>> Get(Guid userId)
        {
            try
            {
                var user = await _service.Get(userId);
                return user == null ? NotFound() : Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }

        // POST api/<UsersController>
        [Authorize("Bearer")]
        [HttpPost("post")]
        public async Task<ActionResult<UserDto>> Post([FromBody] UserDtoCreate user)
        {
            try
            {
                return Ok(await _service.Post(user));
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }

        // PUT api/<UsersController>/5
        [Authorize("Bearer")]
        [HttpPut("put")]
        public async Task<ActionResult<UserDto>> Put([FromBody] UserDtoUpdate user)
        {
            //if (id != vehicle.Id) return BadRequest();

            try
            {
                var result = await _service.Put(user);
                return result == null ? NotFound() : Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }

        // DELETE api/<UsersController>/5
        [Authorize("Bearer")]
        [HttpDelete("delete/{userId}")]
        public async Task<ActionResult<bool>> Delete(Guid userId)
        {
            try
            {
                return Ok(await _service.Delete(userId));
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }
    }
}
