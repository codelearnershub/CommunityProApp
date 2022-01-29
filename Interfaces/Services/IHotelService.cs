using CommunityProApp.Dtos;
using CommunityProApp.Models;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Services
{
    public interface IHotelService
    {
        BaseResponse AddRoom(CreateRoomTypeRequestModel model);
        BaseResponse AddRoom(CreateRoomRequestModel model);

        RoomTypeDto RoomTypeDetail(int id);

        IList<RoomTypeDto> GetRoomTypes();

        IList<RoomTypeDto> GetRoomTypes(int roomTypeId);

        IList<RoomTypeDto> SearchProducts(CheckRoomAvailabilityModel model);
    }
}
