using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.DTOs;
using BaberShopAPI.Shared.ViewModels.Client;

namespace BaberShopAPI.Application.Interfaces
{
    public interface IClientServices
    {
        Task<SeviceResponseDTO<ClientViewModel>> Insert(ClientDTO clientDTO);
        Task<SeviceResponseDTO<ClientDTO>> Delete(int idClient);
        Task<SeviceResponseDTO<ClientDTO>> Get(int idClient);
    }
}