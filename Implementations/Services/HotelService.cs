using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using System.Collections.Generic;

namespace CommunityProApp.Implementations.Services
{
    public class HotelService : IHotelService
    {
        public BaseResponse AddRoom(CreateRoomTypeRequestModel model)
        {
            throw new System.NotImplementedException();
        }

        public BaseResponse AddRoom(CreateRoomRequestModel model)
        {
            throw new System.NotImplementedException();
        }

        public IList<RoomTypeDto> GetRoomTypes()
        {
            throw new System.NotImplementedException();
        }

        public IList<RoomTypeDto> GetRoomTypes(int roomTypeId)
        {
            throw new System.NotImplementedException();
        }

        public RoomTypeDto RoomTypeDetail(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<RoomTypeDto> SearchProducts(CheckRoomAvailabilityModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
