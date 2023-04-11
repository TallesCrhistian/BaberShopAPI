using BaberShopAPI.Shared.Dtos;

namespace BaberShopAPI.Business.Interfaces
{
    public interface IClientBusiness
    {
        Task<ClientDTO> Inserir(ClientDTO clientDTO);
    }
}