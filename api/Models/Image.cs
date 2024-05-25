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