using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class TypeSellerConfiguration : IEntityTypeConfiguration<TypeSeller>
    {
        public void Configure(EntityTypeBuilder<TypeSeller> builder)
        {
            var data = new SeedData();

            builder.HasData(new TypeSeller[] { data.FirstTypeSeller, data.SecondTypeSeller });
        }
    }
}
