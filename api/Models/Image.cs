namespace api.Models
{
    public class Image
    {
        public required int RoomId { get; set; }
        public Room? Room { get; set; }
        public required int Id { get; set; }
        public required string Filename { get; set; }
    }
}