using BaberShopAPI.Shared.Dtos;

namespace BaberShopAPI.Business.Interfaces
{
    public interface IClientBusiness
    {
        Task<ClientDTO> Insert(ClientDTO clientDTO);
        Task<ClientDTO> Delete(int idClient);
    }
}