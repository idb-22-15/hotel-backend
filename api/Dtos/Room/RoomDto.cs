using System.ComponentModel.DataAnnotations;
using api.Dtos.BookedDateRange;
using api.Dtos.Image;

namespace api.Dtos.Room
{
    [Serializable]
    public class RoomDto

    {
        public required int Id { get; set; }
        [MinLength(5)]
        public required string Title { get; set; }
        [Range(1000, 100_000)]
        public required decimal Price { get; set; }
        public required RoomDtoConditions Conditions;
        public required List<BookedDateRangeDto> BookedDateRanges;
        public required List<ImageDto> Images;
    }

    [Serializable]

    public class RoomDtoConditions
    {
        [Range(1, 5)]
        public required int MaxGuests { get; set; }
        [Range(10, 100)]
        public required decimal Square { get; set; }
        public required RoomDtoBeds Beds;
        public required RoomDtoOptions Options;
    }

    [Serializable]
    public class RoomDtoBeds
    {
        public required int Double { get; set; }
        public required int Single { get; set; }
    }

    [Serializable]
    public class RoomDtoOptions
    {
        public bool HasSafe;
        public bool HasConditioner;
        public bool HasShower;
        public bool HasTub;
    }
}