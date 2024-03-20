using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Motorcycle to sell")]
    public class Motorcycle
    {
        [Comment("Motorcycle identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Brand of the motorcycle")]
        [Required]
        [MaxLength(VehicleBrandMaxLength)]
        public string Brand { get; set; } = null!;

        [Comment("Model of the motorcycle")]
        [Required]
        [MaxLength(VehicleModelMaxLength)]
        public string Model { get; set; } = null!;

        [Comment("Color of the motorcycle")]
        [Required]
        [MaxLength(VehicleColorMaxLength)]
        public string Color { get; set; } = null!;

        [Comment("Mileage of the motorcycle")]
        [Required]
        public int Mileage { get; set; }

        [Comment("Horsepower of the motorcycle")]
        [Required]
        public int Horsepower { get; set; }

        [Comment("Motorcycle description")]
        [Required]
        [MaxLength(VehicleDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Comment("Motorcycle image url")]
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Comment("Year of manufacture of the motorcycle")]
        [Required]
        public int Year { get; set; }

        [Comment("Price of the motorcycle")]
        [Required]
        public int Price { get; set; }

        [Comment("Date of the ad")]
        [Required]
        public DateTime DateAd { get; set; }

        [Comment("Category identifier of the motorcycle")]
        [Required]
        public int MotorcycleCategoryId { get; set; }

        [Comment("Category of the motorcycle")]
        [Required]
        [ForeignKey(nameof(MotorcycleCategoryId))]
        public MotorcycleCategory MotorcycleCategory { get; set; } = null!;

        [Required]
        [Comment("Fuel identifier of the motorcycle")]
        public int FuelId { get; set; }

        [Comment("Fuel of the motorcycle")]
        [Required]
        [ForeignKey(nameof(FuelId))]
        public Fuel Fuel { get; set; } = null!;

        [Comment("Type of gears identifier of the motorcycle")]
        [Required]
        public int GearsTypeId { get; set; }

        [Comment("Type of gears of the motorcycle")]
        [Required]
        [ForeignKey(nameof(GearsTypeId))]
        public GearsType GearsType { get; set; } = null!;

        [Comment("Seller identifier of the motorcycle")]
        [Required]
        public int SellerId { get; set; }

        [Comment("Seller of the motorcycle")]
        [Required]
        [ForeignKey(nameof(SellerId))]
        public Seller Seller { get; set; } = null!;

        [Comment("User id of the buyer of the motorcycle")]
        public string? BuyerId { get; set; }
    }
}
