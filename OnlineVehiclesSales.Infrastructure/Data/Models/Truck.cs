using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Truck to sell")]
    public class Truck
    {
        [Comment("Truck identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Brand of the truck")]
        [Required]
        [MaxLength(VehicleBrandMaxLength)]
        public string Brand { get; set; } = null!;

        [Comment("Model of the truck")]
        [Required]
        [MaxLength(VehicleModelMaxLength)]
        public string Model { get; set; } = null!;

        [Comment("Color of the truck")]
        [Required]
        [MaxLength(VehicleColorMaxLength)]
        public string Color { get; set; } = null!;

        [Comment("Mileage of the truck")]
        [Required]
        public int Mileage { get; set; }

        [Comment("Horsepower of the truck")]
        [Required]
        public int Horsepower { get; set; }

        [Comment("Truck description")]
        [Required]
        [MaxLength(VehicleDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Comment("Truck image url")]
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Comment("Year of manufacture of the truck")]
        [Required]
        public int Year { get; set; }

        [Comment("Price of the truck")]
        [Required]
        public int Price { get; set; }

        [Comment("Date of the ad")]
        [Required]
        public DateTime DateAd { get; set; }

        [Comment("Category identifier of the truck")]
        [Required]
        public int TruckCategoryId { get; set; }

        [Comment("Category of the truck")]
        [Required]
        [ForeignKey(nameof(TruckCategoryId))]
        public TruckCategory TruckCategory { get; set; } = null!;

        [Required]
        [Comment("Fuel identifier of the truck")]
        public int FuelId { get; set; }

        [Comment("Fuel of the truck")]
        [Required]
        [ForeignKey(nameof(FuelId))]
        public Fuel Fuel { get; set; } = null!;

        [Comment("Type of gears identifier of the truck")]
        [Required]
        public int GearsTypeId { get; set; }

        [Comment("Type of gears of the truck")]
        [Required]
        [ForeignKey(nameof(GearsTypeId))]
        public GearsType GearsType { get; set; } = null!;

        [Comment("Seller identifier of the truck")]
        [Required]
        public int SellerId { get; set; }

        [Comment("Seller of the truck")]
        [Required]
        [ForeignKey(nameof(SellerId))]
        public Seller Seller { get; set; } = null!;

        [Comment("User id of the buyer of the truck")]
        public string? BuyerId { get; set; }
    }
}
