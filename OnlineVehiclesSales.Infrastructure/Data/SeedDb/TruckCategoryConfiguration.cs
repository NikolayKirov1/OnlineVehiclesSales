using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class TruckCategoryConfiguration : IEntityTypeConfiguration<TruckCategory>
    {
        public void Configure(EntityTypeBuilder<TruckCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new TruckCategory[] { data.FirstTruckCategory, data.SecondTruckCategory,
                data.ThirdTruckCategory, data.FourthTruckCategory, data.FifthTruckCategory,
                data.SixthTruckCategory, data.SeventhTruckCategory, data.EighthTruckCategory,
                data.NinthTruckCategory, data.TenthTruckCategory, data.EleventhTruckCategory,
                data.TwelfthTruckCategory });
        }
    }
}
