using BaberShopAPI.Entities;

namespace BaberShopAPI.Data.Interfaces
{
    public interface IClientRepository
    {
        Task<Client> Inserir(Client client);
    }
}