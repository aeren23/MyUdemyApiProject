using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using System.Runtime.CompilerServices;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig :Profile
    {
        public AutoMapperConfig()
        {   
            CreateMap<AddRoomDto, Room>();
            CreateMap<Room, AddRoomDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }

    }
}

