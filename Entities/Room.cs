
using CommunityProApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Entities
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; }

        public string Image { get; set; }

        public string Image2 { get; set; }

        public string Image3 { get; set; }

        public RoomType Type { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
        public ICollection<HotelBooking> HotelBookings { get; set; } = new List<HotelBooking>();
    }
}
