namespace api.Models
{
    public class Room
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required decimal Price { get; set; }
        public required decimal Square { get; set; }
        public required int MaxGuests { get; set; }
        public required int BedsDouble { get; set; }
        public required int BedsSingle { get; set; }

        public required bool HasSafe { get; set; }
        public required bool HasConditioner { get; set; }
        public required bool HasTub { get; set; }
        public required bool HasShower { get; set; }

        public required List<Image> Images { get; set; }
        public required List<Reservation> Reservations { get; set; }
    }
}