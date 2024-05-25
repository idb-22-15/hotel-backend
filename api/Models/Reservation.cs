namespace api.Models
{
    public class Reservation
    {
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public required ReservationBooker Booker { get; set; }
        public required List<ReservationGuest> Guests { get; set; }
        public string? Wishes { get; set; }
        public bool IsPaid { get; set; }
    }
}