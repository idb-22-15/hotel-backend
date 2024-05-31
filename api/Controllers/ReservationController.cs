using System.Collections;
using api.Dtos.Reservation;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/reservations")]

    public class ReservationController(IRoomRepo roomRepo, IReservationRepo repo, IMailerRepo mailerRepo) : ControllerBase
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
            var roomExists = await roomRepo.ExistsAsync(dto.RoomId);
            if (!roomExists) return BadRequest("Could not create reservation. Room does not exist.");

            var model = dto.ToModelFromCreateDto();
            var created = await repo.CreateAsync(model);
            if (created == null) return BadRequest();

            var createdDto = created.ToDto();
            var jsonCreated = JsonConvert.SerializeObject(createdDto);
            var createTable = (ReservationDto dto) =>
            {
                var tableStart = "<table>";
                var rowStart = "<tr>";
                var rowEnd = "<tr/>";
                var tableEnd = "<table/>";

            };
            var emailMessage = "<strong>All information about booking:<string/> <br/>" + "<pre>" + jsonCreated + "<pre/>";

            await mailerRepo.SendEmailAsync(createdDto.Booker.Email, "Booking is accepted | Hotel Vatrigo", emailMessage);

            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model.ToDto());
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await repo.DeleteAsync(id);
            if (deleted == null) return BadRequest();
            return NoContent();
        }
    }
}