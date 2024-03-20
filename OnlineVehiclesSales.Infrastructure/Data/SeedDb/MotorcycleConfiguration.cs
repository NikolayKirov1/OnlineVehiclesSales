using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class MotorcycleConfiguration : IEntityTypeConfiguration<Motorcycle>
    {
        public void Configure(EntityTypeBuilder<Motorcycle> builder)
        {
            builder
                .HasOne(m => m.MotorcycleCategory)
                .WithMany(mc => mc.Motorcycles)
                .HasForeignKey(m => m.MotorcycleCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.Fuel)
                .WithMany(f => f.Motorcycles)
                .HasForeignKey(m => m.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.GearsType)
                .WithMany(gt => gt.Motorcycles)
                .HasForeignKey(m => m.GearsTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.Seller)
                .WithMany(s => s.Motorcycles)
                .HasForeignKey(m => m.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Motorcycle[] { data.FirstMotorcycle, data.SecondMotorcycle, data.ThirdMotorcycle });
        }
    }
}
