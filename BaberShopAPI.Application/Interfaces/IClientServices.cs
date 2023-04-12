using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.DTOs;

namespace BaberShopAPI.Application.Interfaces
{
    public interface IClientServices
    {
        Task<SeviceResponseDTO<ClientDTO>> Insert(ClientDTO clientDTO);
        Task<SeviceResponseDTO<ClientDTO>> Delete(int idClient);
    }
}