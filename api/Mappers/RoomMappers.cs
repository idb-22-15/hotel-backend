using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Room;
using api.Models;

namespace api.Mappers
{
    public static class RoomMappers
    {
        public static RoomDto ToRoomDto(this Room room)
        {

            var roomDto = new RoomDto
            {
                Id = room.Id,
                Price = room.Price,
                Title = room.Title,
                Conditions = new RoomDto.RoomConditions
                {
                    MaxGuests = room.MaxGuests,
                    Square = room.Square,
                    Beds = new RoomDto.RoomConditions.RoomBeds
                    {
                        Double = room.BedsDouble,
                        Single = room.BedsSingle
                    },
                    Options = new RoomDto.RoomConditions.RoomOptions
                    {
                        HasSafe = room.HasSafe,
                        HasConditioner = room.HasConditioner,
                        HasShower = room.HasShower,
                        HasTub = room.HasTub,
                    }

                }
            };
            return roomDto;
        }

        public static Room ToRoomFromCreateRoomDto(this CreateRoomDto dto)
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
                HasTub = dto.Conditions.Options.HasTub
            };
            return room;
        }
    }
}