using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Room
{
    public class CreateRoomDto
    {
        public required string Title { get; set; }
        public required decimal Price { get; set; }

        public required RoomConditions Conditions;

        [Serializable]
        public class RoomConditions
        {
            public required int MaxGuests { get; set; }
            public required decimal Square { get; set; }

            public required RoomBeds Beds;

            [Serializable]
            public class RoomBeds
            {
                public required int Double { get; set; }
                public required int Single { get; set; }
            }

            public required List<string> Options;
        }
    }
}