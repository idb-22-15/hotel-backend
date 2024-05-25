namespace api.Dtos.Room
{
    [Serializable]
    public class CreateRoomDto

    {
        public required string Title { get; set; }
        public required decimal Price { get; set; }

        public required RoomConditions Conditions { get; set; }
        [Serializable]

        public class RoomConditions
        {
            public required int MaxGuests { get; set; }
            public required decimal Square { get; set; }

            public required RoomBeds Beds { get; set; }
            [Serializable]

            public class RoomBeds
            {
                public required int Double { get; set; }
                public required int Single { get; set; }
            }


            public required RoomOptions Options { get; set; }
            [Serializable]
            public class RoomOptions
            {
                public bool HasSafe { get; set; }
                public bool HasConditioner { get; set; }
                public bool HasShower { get; set; }
                public bool HasTub { get; set; }
            }
        }
    }
}