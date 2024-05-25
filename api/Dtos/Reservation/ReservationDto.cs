using api.Dtos.Room;

namespace api.Dtos.Reservation
{
    public class ReservationDto
    {
        public int RoomId { get; set; }
        public RoomDto? Room { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public required ReservationBookerDto Booker { get; set; }
        public required List<ReservationGuestDto> Guests { get; set; }
        public string? Wishes { get; set; }
        public bool IsPaid { get; set; }
    }

    public class ReservationBookerDto

    {
        public int ReservationId { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }

    public class ReservationGuestDto
    {
        public int ReservationGuestId { get; set; }
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public bool IsChild { get; set; }
        public int? Age { get; set; }
    }
}