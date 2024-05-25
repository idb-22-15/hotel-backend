using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.BookedDateRange
{
    public class CreateBookedDateRangeDto
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int RoomId { get; set; }
    }
}