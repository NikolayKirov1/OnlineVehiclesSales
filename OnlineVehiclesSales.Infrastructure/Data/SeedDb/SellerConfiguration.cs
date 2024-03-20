using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            var data = new SeedData();

            builder.HasData(new Seller[] { data.Seller });
        }
    }
}
