using Microsoft.EntityFrameworkCore;
using OnlineVehiclesSales.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class VanCategoryConfiguration : IEntityTypeConfiguration<VanCategory>
    {
        public void Configure(EntityTypeBuilder<VanCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new VanCategory[] { data.FirstVanCategory, data.SecondVanCategory, data.ThirdVanCategory,
             data.FourthVanCategory, data.FifthVanCategory });
        }
    }
}
