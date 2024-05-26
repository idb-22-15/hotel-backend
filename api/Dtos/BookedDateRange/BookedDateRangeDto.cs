namespace api.Dtos.BookedDateRange
{
    public class BookedDateRangeDto
    {
        public required int RoomId { get; set; }
        public required DateTime Start { get; set; }
        public required DateTime End { get; set; }
    }
}