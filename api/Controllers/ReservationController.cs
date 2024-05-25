using api.Dtos.Reservation;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/reservation")]

    public class ReservationController(IReservationRepo repo) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var model = await repo.GetByIdAsync(id);
            if (model == null) return NotFound();
            return Ok(model.ToDto());

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var models = await repo.GetAllAsync();
            return Ok(models.Select(r => r.ToDto()));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReservationDto dto)
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