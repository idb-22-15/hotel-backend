using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.BookedDateRange;
using api.Models;

namespace api.Mappers
{
    public static class BookedDateRangeMapper
    {
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