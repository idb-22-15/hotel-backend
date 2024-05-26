namespace api.Models
{
    public class ReservationGuest
    {
        public required int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string? MiddleName { get; set; }
        public required bool IsChild { get; set; }
        public required int? Age { get; set; }
    }
}