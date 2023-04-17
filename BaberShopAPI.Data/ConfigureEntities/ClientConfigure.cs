using BaberShopAPI.Entities;
using BaberShopAPI.Shared.Enumerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaberShopAPI.Data.ConfigureEntities
{
    public class ClientConfigure : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdClient);

            entityTypeBuilder.Property(e => e.Gender)
                .HasColumnName("enum_gender")
                .HasColumnType("enum_gender")
                .HasDefaultValue(EnumGender.other)
                .IsRequired();
        }
    }
}
