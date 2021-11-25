using GameServer.API.Domain.Dtos.ListModel;
using GameServer.API.Domain.Dtos.Server;
using GameServer.API.Domain.Interfaces.Services.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameServer.API.Aplication.Controllers
{
    [Route("api/servers")]
    [ApiController]
    public class ServersController : ControllerBase
    {
        private readonly IServerService _service;

        public ServersController(IServerService _service)
        {
            this._service = _service;
        }
        // GET: api/<UsersController>
        [Authorize("Bearer")]
        [HttpGet("getAll/{skip}/{take}")]
        public async Task<ActionResult<ListModel<ServerDto>>> GetAll(int skip, int take)
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

        // GET api/<UsersController>/5
        [Authorize("Bearer")]
        [HttpGet("get/{serverId}")]
        public async Task<ActionResult<ServerDto>> Get(Guid serverId)
        {
            try
            {
                var server = await _service.Get(serverId);
                return server == null ? NotFound() : Ok(server);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }

        // POST api/<UsersController>
        [Authorize("Bearer")]
        [HttpPost("post")]
        public async Task<ActionResult<ServerDto>> Post([FromBody] ServerDtoCreate server)
        {
            try
            {
                return Ok(await _service.Post(server));
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }

        // PUT api/<UsersController>/5
        [Authorize("Bearer")]
        [HttpPut("put")]
        public async Task<ActionResult<ServerDto>> Put([FromBody] ServerDtoUpdate server)
        {
            //if (id != vehicle.Id) return BadRequest();

            try
            {
                var result = await _service.Put(server);
                return result == null ? NotFound() : Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }

        // DELETE api/<UsersController>/5
        [Authorize("Bearer")]
        [HttpDelete("delete/{serverId}")]
        public async Task<ActionResult<bool>> Delete(Guid serverId)
        {
            try
            {
                return Ok(await _service.Delete(serverId));
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex}");
            }
        }
    }
}
