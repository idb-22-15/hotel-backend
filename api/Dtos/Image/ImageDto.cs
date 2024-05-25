using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Image
{
    public class ImageDto
    {
        public int Id { get; set; }
        public required string Filename { get; set; }
        public int RoomId { get; set; }
    }
}