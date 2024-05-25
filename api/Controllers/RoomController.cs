using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Controllers;
using api.Data;
using api.Dtos.Room;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("/api/rooms")]
    [ApiController]
    public class RoomController(IRoomRepo roomRepo) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var room = await roomRepo.GetByIdAsync(id);
            if (room == null) return NotFound();
            return Ok(room.ToRoomDto());

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var rooms = await roomRepo.GetAllAsync();
            return Ok(rooms.Select(r => r.ToRoomDto()));
        }

        [HttpPost]
        async Task<IActionResult> Create([FromBody] CreateRoomDto dto)
        {
            await roomRepo.CreateAsync(dto);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await roomRepo.DeleteAsync(id);
            return NoContent();
        }
    }
}
