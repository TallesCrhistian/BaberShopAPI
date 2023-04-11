using BaberShopAPI.Data.Interfaces;
using BaberShopAPI.Entities;

namespace BaberShopAPI.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        private AppDbContext _appDbContext;

        public ClientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Client> Inserir(Client client)
        {
            await _appDbContext.Set<Client>().AddAsync(client);
            await _appDbContext.SaveChangesAsync();

            return client;
        }

    }
}
