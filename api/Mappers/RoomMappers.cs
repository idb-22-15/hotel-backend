using api.Dtos.Room;
using api.Models;

namespace api.Mappers
{
    public static class RoomMappers
    {
        public static RoomDto ToDto(this Room room)
        {

            var roomDto = new RoomDto
            {
                Id = room.Id,
                Price = room.Price,
                Title = room.Title,
                Conditions = new RoomDtoConditions
                {
                    MaxGuests = room.MaxGuests,
                    Square = room.Square,
                    Beds = new RoomDtoBeds
                    {
                        Double = room.BedsDouble,
                        Single = room.BedsSingle
                    },
                    Options = new RoomDtoOptions
                    {
                        HasSafe = room.HasSafe,
                        HasConditioner = room.HasConditioner,
                        HasShower = room.HasShower,
                        HasTub = room.HasTub,
                    }
                },
                BookedDateRanges = room.Reservations == null ? [] : room.Reservations.Select(r => r.ToBookedDateRangeDto()).ToList(),
                Images = room.Images == null ? [] : room.Images.Select(img => img.ToDto()).ToList(),
            };
            return roomDto;
        }

        public static Room ToModelFromCreateDto(this CreateRoomDto dto)
        {
            var room = new Room
            {
                Title = dto.Title,
                Price = dto.Price,
                MaxGuests = dto.Conditions.MaxGuests,
                BedsSingle = dto.Conditions.Beds.Single,
                BedsDouble = dto.Conditions.Beds.Double,
                HasSafe = dto.Conditions.Options.HasSafe,
                HasConditioner = dto.Conditions.Options.HasConditioner,
                HasShower = dto.Conditions.Options.HasShower,
                HasTub = dto.Conditions.Options.HasTub,
                Images = [],
                Reservations = []
            };
            return room;
        }
    }
}