using BaberShopAPI.Shared.Dtos;
using BaberShopAPI.Shared.ViewModels.Client;

namespace BaberShopAPI.Business.Interfaces
{
    public interface IClientBusiness
    {
        Task<ClientViewModel> Insert(ClientDTO clientDTO);
        Task<ClientDTO> Delete(int idClient);
        Task<ClientDTO> Get(int idClient);
    }
}