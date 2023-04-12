using BaberShopAPI.Data.Interfaces;
using BaberShopAPI.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Client> Delete(int idClient)
        {
            Client client = await _appDbContext.Customers.Where(x => x.IdClient == idClient).FirstOrDefaultAsync();

            if (client != null)
            {
                client.Active = false;
                _appDbContext.Set<Client>().Update(client);
                await _appDbContext.SaveChangesAsync();
            }

            return client;
        }
    }
}
