using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Image
    {
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public int Id { get; set; }
        public required string Filename { get; set; }
    }
}