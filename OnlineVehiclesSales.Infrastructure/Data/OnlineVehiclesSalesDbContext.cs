using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineVehiclesSales.Infrastructure.Data.Models;
using OnlineVehiclesSales.Infrastructure.Data.SeedDb;

namespace OnlineVehiclesSales.Infrastructure.Data
{
    public class OnlineVehiclesSalesDbContext : IdentityDbContext
    {
        public OnlineVehiclesSalesDbContext(DbContextOptions<OnlineVehiclesSalesDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarCategoryConfiguration());
            builder.ApplyConfiguration(new CarConfiguration());
            builder.ApplyConfiguration(new FuelConfiguration());
            builder.ApplyConfiguration(new GearsTypeConfiguration());
            builder.ApplyConfiguration(new MotorcycleCategoryConfiguration());
            builder.ApplyConfiguration(new MotorcycleConfiguration());
            builder.ApplyConfiguration(new SellerConfiguration());
            builder.ApplyConfiguration(new TruckCategoryConfiguration());
            builder.ApplyConfiguration(new TruckConfiguration());
            builder.ApplyConfiguration(new TypeSellerConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new VanCategoryConfiguration());
            builder.ApplyConfiguration(new VanConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<CarCategory> CarCategories { get; set; } = null!;

        public DbSet<Fuel> Fuels { get; set; } = null!;

        public DbSet<GearsType> GearsTypes { get; set; } = null!;

        public DbSet<Motorcycle> Motorcycles { get; set; } = null!;

        public DbSet<MotorcycleCategory> MotorcycleCategories { get; set; } = null!;

        public DbSet<Seller> Sellers { get; set; } = null!;

        public DbSet<Truck> Trucks { get; set; } = null!;

        public DbSet<TruckCategory> TruckCategories { get; set; } = null!;

        public DbSet<TypeSeller> TypeSellers { get; set; } = null!;

        public DbSet<Van> Vans { get; set; } = null!;

        public DbSet<VanCategory> VanCategories { get; set; } = null!;
    }
}