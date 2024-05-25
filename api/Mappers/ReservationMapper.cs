using api.Dtos.BookedDateRange;
using api.Dtos.Reservation;
using api.Models;

namespace api.Mappers
{
    public static class ReservationMapper
    {
        public static BookedDateRangeDto ToBookedDateRangeDto(this Reservation reservation)
        {
            var bookedDateRange = new BookedDateRangeDto
            {
                RoomId = reservation.RoomId,
                Start = reservation.CheckIn,
                End = reservation.CheckOut,
            };
            return bookedDateRange;
        }

        public static Reservation ToReservationFromCreateDto(this ReservationDto dto)
        {
            var reservation = new Reservation
            {
                RoomId = dto.RoomId,
                CheckIn = dto.CheckIn,
                CheckOut = dto.CheckOut,
                Wishes = dto.Wishes,
                Booker = null!,
                Guests = [],
                IsPaid = dto.IsPaid,
            };
            var booker = new ReservationBooker
            {
                ReservationId = reservation.Id,
                Reservation = reservation,
                Name = dto.Booker.Name,
                LastName = dto.Booker.LastName,
                MiddleName = dto.Booker.MiddleName,
                Email = dto.Booker.Email,
                Phone = dto.Booker.Phone,
            };
            var guests = dto.Guests.Select(guest => new ReservationGuest
            {
                ReservationId = reservation.Id,
                Reservation = reservation,
                Name = guest.Name,
                LastName = guest.LastName,
                MiddleName = guest.MiddleName,
            }).ToList();

            reservation.Booker = booker;
            reservation.Guests = guests;

            return reservation;
        }
    }
}