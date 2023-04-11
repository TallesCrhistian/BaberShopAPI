using BaberShopAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaberShopAPI.Data.ConfigureEntities
{
    internal class ClientConfigure : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdClient);
        }
    }
}
