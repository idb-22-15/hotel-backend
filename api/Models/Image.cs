using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Image
    {
        public int Id { get; set; }
        public required string filename { get; set; }

        public int RoomId { get; set; }
        public required Room Room { get; set; }
    }
}