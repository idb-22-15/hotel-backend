using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.BookedDateRange;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("/api/booked-date-ranges")]
    [ApiController]
    public class BookedDateRangeController(ApplicationDbContext db) : ControllerBase
    {
        private readonly ApplicationDbContext db = db;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var bookedDateRange = await db.BookedDateRanges.FindAsync(id);
            if (bookedDateRange == null) return NotFound();
            return Ok(bookedDateRange);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookedDateRanges = await db.BookedDateRanges.ToListAsync();
            return Ok(bookedDateRanges);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] CreateBookedDateRangeDto dto)
        {
            var bookedDateRange = dto.ToBookedDateRangeFromCreateDto();
            await db.BookedDateRanges.AddAsync(bookedDateRange);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var bookedDateRange = await db.BookedDateRanges.FindAsync(id);
            if (bookedDateRange == null) return NotFound();
            db.BookedDateRanges.Remove(bookedDateRange);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}