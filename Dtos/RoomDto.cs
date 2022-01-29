using System;

namespace CommunityProApp.Dtos
{
    public class RoomTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public string Image2 { get; set; }

        public string Image3 { get; set; }

        public decimal Price { get; set; }

        public int MaxNumberOfAdult { get; set; }
    }

    public class CreateRoomTypeRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public string Image2 { get; set; }

        public string Image3 { get; set; }

        public decimal Price { get; set; }

        public int MaxNumberOfAdult { get; set; }
    }

    public class CreateRoomRequestModel
    {
        public int RoomTypeId { get; set; }

    }

    public class CheckRoomAvailabilityModel
    {
        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int RoomType { get; set; }

        public int NumberOfAdults { get; set; }

    }
}
