using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Reservation
{
    public class CreateReservationDto
    {
        public required int RoomId { get; set; }
        public required decimal TotalPrice { get; set; }
        public required DateTime CheckIn { get; set; }
        public required DateTime CheckOut { get; set; }
        public required ReservationBookerDto Booker { get; set; }
        public required List<ReservationGuestDto> Guests { get; set; }
        public required string? Wishes { get; set; } = null;
        public required bool IsPaid { get; set; } = false;
    }

    public class CreateReservationBookerDto

    {
        [MinLength(2)]
        public required string Name { get; set; }
        [MinLength(2)]
        public required string LastName { get; set; }
        [MinLength(2)]
        public required string? MiddleName { get; set; }
        [EmailAddress()]
        public required string Email { get; set; }
        [MinLength(2)]
        public required string Phone { get; set; }
    }

    public class CreateReservationGuestDto
    {

        [MinLength(2)]
        public required string Name { get; set; }
        [MinLength(2)]
        public required string LastName { get; set; }
        [MinLength(2)]
        public required string? MiddleName { get; set; }
        public required bool IsChild { get; set; } = false;
        public required int? Age { get; set; } = null;
    }
}