using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.DTOs;

namespace BaberShopAPI.Application.Interfaces
{
    public interface IClientServices
    {
        Task<SeviceResponseDTO<ClientDTO>> Inserir(ClientDTO clientDTO);
    }
}