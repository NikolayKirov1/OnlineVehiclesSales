using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVehiclesSales.Infrastructure.Data.Models;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class VanConfiguration : IEntityTypeConfiguration<Van>
    {
        public void Configure(EntityTypeBuilder<Van> builder)
        {
            builder
                .HasOne(v => v.VanCategory)
                .WithMany(vc => vc.Vans)
                .HasForeignKey(v => v.VanCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(v => v.Fuel)
                .WithMany(f => f.Vans)
                .HasForeignKey(v => v.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(v => v.GearsType)
                .WithMany(gt => gt.Vans)
                .HasForeignKey(v => v.GearsTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(v => v.Seller)
                .WithMany(s => s.Vans)
                .HasForeignKey(v => v.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Van[] { data.FirstVan, data.SecondVan, data.ThirdVan });
        }
    }
}
