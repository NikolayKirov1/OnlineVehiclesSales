using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Van to sell")]
    public class Van
    {
        [Comment("Van identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Brand of the van")]
        [Required]
        [MaxLength(VehicleBrandMaxLength)]
        public string Brand { get; set; } = null!;

        [Comment("Model of the van")]
        [Required]
        [MaxLength(VehicleModelMaxLength)]
        public string Model { get; set; } = null!;

        [Comment("Color of the van")]
        [Required]
        [MaxLength(VehicleColorMaxLength)]
        public string Color { get; set; } = null!;

        [Comment("Mileage of the van")]
        [Required]
        public int Mileage { get; set; }

        [Comment("Horsepower of the van")]
        [Required]
        public int Horsepower { get; set; }

        [Comment("Van description")]
        [Required]
        [MaxLength(VehicleDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Comment("Van image url")]
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Comment("Year of manufacture of the van")]
        [Required]
        public int Year { get; set; }

        [Comment("Price of the van")]
        [Required]
        public int Price { get; set; }

        [Comment("Date of the ad")]
        [Required]
        public DateTime DateAd { get; set; }

        [Comment("Category identifier of the van")]
        [Required]
        public int VanCategoryId { get; set; }

        [Comment("Category of the van")]
        [Required]
        [ForeignKey(nameof(VanCategoryId))]
        public VanCategory VanCategory { get; set; } = null!;

        [Required]
        [Comment("Fuel identifier of the van")]
        public int FuelId { get; set; }

        [Comment("Fuel of the van")]
        [Required]
        [ForeignKey(nameof(FuelId))]
        public Fuel Fuel { get; set; } = null!;

        [Comment("Type of gears identifier of the van")]
        [Required]
        public int GearsTypeId { get; set; }

        [Comment("Type of gears of the van")]
        [Required]
        [ForeignKey(nameof(GearsTypeId))]
        public GearsType GearsType { get; set; } = null!;

        [Comment("Seller identifier of the van")]
        [Required]
        public int SellerId { get; set; }

        [Comment("Seller of the van")]
        [Required]
        [ForeignKey(nameof(SellerId))]
        public Seller Seller { get; set; } = null!;

        [Comment("User id of the buyer of the van")]
        public string? BuyerId { get; set; }
    }
}
