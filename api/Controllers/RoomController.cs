using api.Dtos.Room;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/rooms")]
    public class RoomController(IRoomRepo repo) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var model = await repo.GetByIdAsync(id);
            if (model == null) return NotFound();
            Console.WriteLine("get one");
            return Ok(model.ToDto());

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var models = await repo.GetAllAsync();
            return Ok(models.Select(r => r.ToDto()));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRoomDto dto)
        {
            var model = dto.ToModelFromCreateDto();
            await repo.CreateAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model.ToDto());
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await repo.DeleteAsync(id);
            return NoContent();
        }
    }
}
