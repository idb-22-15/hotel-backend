using api.Dtos.Room;

namespace api.Dtos.Reservation
{
    public class ReservationDto
    {
        public required int RoomId { get; set; }
        public RoomDto? Room { get; set; }
        public required int Id { get; set; }
        public required DateTime CheckIn { get; set; }
        public required DateTime CheckOut { get; set; }
        public required ReservationBookerDto Booker { get; set; }
        public required List<ReservationGuestDto> Guests { get; set; }
        public required string? Wishes { get; set; }
        public required bool IsPaid { get; set; }
    }

    public class ReservationBookerDto

    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string? MiddleName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }

    public class ReservationGuestDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string? MiddleName { get; set; }
        public required bool IsChild { get; set; }
        public required int? Age { get; set; }
    }
}