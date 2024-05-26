namespace api.Models
{
    public class Reservation
    {
        public required int RoomId { get; set; }
        public Room? Room { get; set; }
        public int Id { get; set; }
        public required DateTime CheckIn { get; set; }
        public required DateTime CheckOut { get; set; }
        public required ReservationBooker Booker { get; set; }
        public required List<ReservationGuest> Guests { get; set; }
        public required string? Wishes { get; set; }
        public required bool IsPaid { get; set; }
    }
}