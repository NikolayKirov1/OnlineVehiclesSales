using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasOne(c => c.CarCategory)
                .WithMany(cc => cc.Cars)
                .HasForeignKey(c => c.CarCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Fuel)
                .WithMany(f => f.Cars)
                .HasForeignKey(c => c.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.GearsType)
                .WithMany(gt => gt.Cars)
                .HasForeignKey(c => c.GearsTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Seller)
                .WithMany(s => s.Cars)
                .HasForeignKey(c => c.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Car[] { data.FirstCar, data.SecondCar, data.ThirdCar });
        }
    }
}
