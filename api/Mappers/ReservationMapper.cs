using api.Dtos.BookedDateRange;
using api.Dtos.Reservation;
using api.Models;

namespace api.Mappers
{
    public static class ReservationMapper
    {
        public static ReservationDto ToDto(this Reservation reservation)
        {
            var dto = new ReservationDto
            {
                RoomId = reservation.RoomId,
                Id = reservation.Id,
                TotalPrice = reservation.TotalPrice,
                CheckIn = reservation.CheckIn,
                CheckOut = reservation.CheckOut,
                Wishes = reservation.Wishes,
                IsPaid = reservation.IsPaid,
                Booker = new ReservationBookerDto
                {
                    Id = reservation.Booker.Id,
                    Name = reservation.Booker.Name,
                    LastName = reservation.Booker.LastName,
                    MiddleName = reservation.Booker.MiddleName,
                    Email = reservation.Booker.Email,
                    Phone = reservation.Booker.Phone,
                },
                Guests = reservation.Guests.Select(guest => new ReservationGuestDto
                {
                    Id = guest.Id,
                    Name = guest.Name,
                    LastName = guest.LastName,
                    MiddleName = guest.MiddleName,
                    IsChild = guest.IsChild,
                    Age = guest.Age,
                }).ToList(),
                Room = reservation.Room?.ToDto(),
            };
            return dto;
        }
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

        public static Reservation ToModelFromCreateDto(this CreateReservationDto dto)
        {
            var reservation = new Reservation
            {
                RoomId = dto.RoomId,
                TotalPrice = dto.TotalPrice,
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
                IsChild = guest.IsChild,
                Age = guest.Age,
            }).ToList();

            reservation.Booker = booker;
            reservation.Guests = guests;

            return reservation;
        }
    }
}