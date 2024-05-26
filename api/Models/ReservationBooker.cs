namespace api.Models
{
    public class ReservationBooker
    {
        public required int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string? MiddleName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }
}