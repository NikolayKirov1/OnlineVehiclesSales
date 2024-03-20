using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class MotorcycleCategoryConfiguration : IEntityTypeConfiguration<MotorcycleCategory>
    {
        public void Configure(EntityTypeBuilder<MotorcycleCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new MotorcycleCategory[] { data.FirstMotorcycleCategory, data.SecondMotorcycleCategory,
                data.ThirdMotorcycleCategory, data.FourthMotorcycleCategory, data.FifthMotorcycleCategory,
                data.SixthMotorcycleCategory, data.SeventhMotorcycleCategory, data.EighthMotorcycleCategory,
                data.NinthMotorcycleCategory, data.TenthMotorcycleCategory, data.EleventhMotorcycleCategory,
                data.TwelfthMotorcycleCategory });
        }
    }
}
