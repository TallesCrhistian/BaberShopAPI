using AutoMapper;
using BaberShopAPI.Entities;
using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.ViewModels.Client;

namespace BaberShopAPI.Utils.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<InsertClientViewModel, ClientDTO>()
                .ReverseMap();
            CreateMap<ClientDTO, Client>()
                .ReverseMap();
        }
    }
}
