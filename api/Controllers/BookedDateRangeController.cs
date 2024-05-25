using api.Dtos.BookedDateRange;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("/api/booked-date-ranges")]
    [ApiController]
    public class BookedDateRangeController(IBookedDateRangeRepo bookedRepo) : ControllerBase
    {

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var bookedDateRange = await bookedRepo.GetByIdAsync(id);
            if (bookedDateRange == null) return NotFound();
            return Ok(bookedDateRange.ToBookedDateRangeDto());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookedDateRanges = await bookedRepo.GetAllAsync();
            return Ok(bookedDateRanges.Select(b => b.ToBookedDateRangeDto()));
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] CreateBookedDateRangeDto dto)
        {
            var bookedDateRange = dto.ToBookedDateRangeFromCreateDto();
            await bookedRepo.CreateAsync(bookedDateRange);
            return CreatedAtAction(nameof(GetById), new { id = bookedDateRange.Id }, bookedDateRange.ToBookedDateRangeDto());
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var bookedDateRange = await bookedRepo.DeleteAsync(id);
            if (bookedDateRange == null) return NotFound();
            return NoContent();
        }
    }
}