using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Image
{
    public class ImageDto
    {
        public required int Id { get; set; }
        [MinLength(2)]
        public required string Url { get; set; }
        public required int RoomId { get; set; }
    }
}