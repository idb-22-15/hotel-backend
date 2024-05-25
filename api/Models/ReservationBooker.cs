using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class ReservationBooker
    {
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }
}