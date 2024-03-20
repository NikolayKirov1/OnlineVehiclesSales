using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class TruckConfiguration : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> builder)
        {
            builder
                .HasOne(t => t.TruckCategory)
                .WithMany(tc => tc.Trucks)
                .HasForeignKey(t => t.TruckCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.Fuel)
                .WithMany(f => f.Trucks)
                .HasForeignKey(t => t.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.GearsType)
                .WithMany(gt => gt.Trucks)
                .HasForeignKey(t => t.GearsTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.Seller)
                .WithMany(s => s.Trucks)
                .HasForeignKey(t => t.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Truck[] { data.FirstTruck, data.SecondTruck, data.ThirdTruck });
        }
    }
}
