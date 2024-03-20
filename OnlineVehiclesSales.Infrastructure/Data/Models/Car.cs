using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Car to sell")]
    public class Car
    {
        [Comment("Car identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Brand of the car")]
        [Required]
        [MaxLength(VehicleBrandMaxLength)]
        public string Brand { get; set; } = null!;

        [Comment("Model of the car")]
        [Required]
        [MaxLength(VehicleModelMaxLength)]
        public string Model { get; set; } = null!;

        [Comment("Color of the car")]
        [Required]
        [MaxLength(VehicleColorMaxLength)]
        public string Color { get; set; } = null!;

        [Comment("Mileage of the car")]
        [Required]
        public int Mileage { get; set; }

        [Comment("Horsepower of the car")]
        [Required]
        public int Horsepower { get; set; }

        [Comment("Car description")]
        [Required]
        [MaxLength(VehicleDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Comment("Car image url")]
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Comment("Year of manufacture of the car")]
        [Required]
        public int Year { get; set; }

        [Comment("Price of the car")]
        [Required]
        public int Price { get; set; }

        [Comment("Date of the ad")]
        [Required]
        public DateTime DateAd { get; set; }

        [Comment("Category identifier of the car")]
        [Required]
        public int CarCategoryId { get; set; }

        [Comment("Category of the car")]
        [Required]
        [ForeignKey(nameof(CarCategoryId))]
        public CarCategory CarCategory { get; set; } = null!;

        [Required]
        [Comment("Fuel identifier of the car")]
        public int FuelId { get; set; }

        [Comment("Fuel of the car")]
        [Required]
        [ForeignKey(nameof(FuelId))]
        public Fuel Fuel { get; set; } = null!;

        [Comment("Type of gears identifier of the car")]
        [Required]
        public int GearsTypeId { get; set; }

        [Comment("Type of gears of the car")]
        [Required]
        [ForeignKey(nameof(GearsTypeId))]
        public GearsType GearsType { get; set; } = null!;

        [Comment("Seller identifier of the car")]
        [Required]
        public int SellerId { get; set; }

        [Comment("Seller of the car")]
        [Required]
        [ForeignKey(nameof(SellerId))]
        public Seller Seller { get; set; } = null!;

        [Comment("User id of the buyer of the car")]
        public string? BuyerId { get; set; }
    }
}
