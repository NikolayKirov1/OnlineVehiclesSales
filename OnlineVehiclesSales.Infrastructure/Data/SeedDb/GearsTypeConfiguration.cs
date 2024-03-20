using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class GearsTypeConfiguration : IEntityTypeConfiguration<GearsType>
    {
        public void Configure(EntityTypeBuilder<GearsType> builder)
        {
            var data = new SeedData();

            builder.HasData(new GearsType[] { data.FirstGearsType, data.SecondGearsType });
        }
    }
}
