using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("/api/rooms")]
    [ApiController]
    public class RoomController(ApplicationDbContext db) : ControllerBase
    {
        private readonly ApplicationDbContext db = db;


        [HttpGet]
        public IActionResult GetAll()
        {
            var rooms = db.Rooms.ToList();
            return Ok(rooms);
        }


        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var room = db.Rooms.Find(id);
            if (room == null) return NotFound();
            return Ok(room);

        }

        [HttpPost]
        public IActionResult Create()
        {
            var room = new Room
            {
                Title = "Номер №2",
                Price = 4000,
                BedsSingle = 1,
                BedsDouble = 2,
                HasConditioner = true,
                HasSafe = true,
                HasTub = true,
                MaxGuests = 4,
                Square = 40
            };
            db.Rooms.Add(room);
            return Ok(room);
        }

    }

}