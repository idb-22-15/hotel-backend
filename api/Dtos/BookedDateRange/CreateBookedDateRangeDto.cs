namespace api.Dtos.BookedDateRange
{
    public class CreateBookedDateRangeDto
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int RoomId { get; set; }
    }
}