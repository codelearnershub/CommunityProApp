using CommunityProApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Entities
{
    public class HotelBooking : BaseEntity
    {
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public Guid RoomId { get; set; }

        public Room Room { get; set; }

        public decimal RoomPrice { get; set; }

        public BookingStatus Status { get; set; }

        public DateTime From { get; set; }

        public int Duration { get; set; }

        
    }
}
