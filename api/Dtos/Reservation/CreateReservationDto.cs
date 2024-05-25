namespace api.Dtos.Reservation
{
    public class CreateReservationDto
    {
        public int RoomId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public required ReservationBookerDto Booker { get; set; }
        public required List<ReservationGuestDto> Guests { get; set; }
        public string? Wishes { get; set; }
        public bool IsPaid { get; set; }
    }

    public class CreateReservationBookerDto

    {
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }

    public class CreateReservationGuestDto
    {
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public bool IsChild { get; set; }
        public int? Age { get; set; }
    }
}