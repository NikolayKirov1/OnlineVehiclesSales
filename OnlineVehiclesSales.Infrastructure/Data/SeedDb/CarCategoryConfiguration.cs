using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class CarCategoryConfiguration : IEntityTypeConfiguration<CarCategory>
    {
        public void Configure(EntityTypeBuilder<CarCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new CarCategory[] { data.FirstCarCategory, data.SecondCarCategory, data.ThirdCarCategory,
             data.FourthCarCategory, data.FifthCarCategory, data.SixthCarCategory, data.SeventhCarCategory,
             data.EighthCarCategory});
        }
    }
}
