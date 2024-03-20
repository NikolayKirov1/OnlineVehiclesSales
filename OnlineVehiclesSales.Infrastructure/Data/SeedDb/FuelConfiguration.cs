using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class FuelConfiguration : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            var data = new SeedData();

            builder.HasData(new Fuel[] { data.FirstFuel, data.SecondFuel, data.ThirdFuel,
             data.FourthFuel, data.FifthFuel, data.SixthFuel });
        }
    }
}
