using api.Dtos.BookedDateRange;
using api.Models;

namespace api.Mappers
{
    public static class BookedDateRangeMapper
    {
        public static BookedDateRangeDto ToBookedDateRangeDto(this BookedDateRange bookedDateRange)
        {
            var dto = new BookedDateRangeDto
            {
                Start = bookedDateRange.Start,
                End = bookedDateRange.End,
                RoomId = bookedDateRange.RoomId,
            };
            return dto;
        }
        public static BookedDateRange ToBookedDateRangeFromCreateDto(this CreateBookedDateRangeDto dto)
        {
            var bookedDateRange = new BookedDateRange
            {
                RoomId = dto.RoomId,
                Start = dto.Start,
                End = dto.End,
            };
            return bookedDateRange;
        }
    }
}