using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Room;

namespace api.Dtos.BookedDateRange
{
    public class BookedDateRangeDto
    {
        public required int RoomId { get; set; }
        public required DateTime Start { get; set; }
        public required DateTime End { get; set; }
    }
}