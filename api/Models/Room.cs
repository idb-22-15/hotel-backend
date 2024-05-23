using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Room
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public decimal Price { get; set; }
        public decimal Square { get; set; }
        public int MaxGuests { get; set; }
        public int BedsDouble { get; set; }
        public int BedsSingle { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();

        public bool HasSafe { get; set; }
        public bool HasConditioner { get; set; }
        public bool HasTub { get; set; }
        public bool HasShower { get; set; }
    }
}