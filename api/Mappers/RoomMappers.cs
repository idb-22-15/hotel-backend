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
                    Options = []

                }
            };
            if (room.HasSafe) roomDto.Conditions.Options.Add("has-safe");
            if (room.HasConditioner) roomDto.Conditions.Options.Add("has-conditioner");
            if (room.HasTub) roomDto.Conditions.Options.Add("has-tub");
            if (room.HasShower) roomDto.Conditions.Options.Add("has-shower");
            return roomDto;
        }

        public static Room ToRoomFromCreateRoomDto(this CreateRoomDto dto)
        {


        }
    }
}