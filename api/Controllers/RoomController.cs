using api.Dtos.Room;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Create([FromBody] CreateRoomDto dto)
        {
            var room = dto.ToRoomFromCreateRoomDto();
            await roomRepo.CreateAsync(room);
            return CreatedAtAction(nameof(GetById), new { id = room.Id }, room.ToRoomDto());
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await roomRepo.DeleteAsync(id);
            return NoContent();
        }
    }
}
