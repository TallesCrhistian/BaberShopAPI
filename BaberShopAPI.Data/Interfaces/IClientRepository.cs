using BaberShopAPI.Entities;

namespace BaberShopAPI.Data.Interfaces
{
    public interface IClientRepository
    {
        Task<Client> Inserir(Client client);
        Task<Client> Delete(int idClient);
        Task<Client> Get(int idClient);
    }
}