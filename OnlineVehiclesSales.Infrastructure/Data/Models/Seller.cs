using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Vehicle seller")]
    public class Seller
    {
        [Comment("Seller identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Type identifier of the seller")]
        [Required]
        public int TypeSellerId { get; set; }

        [Comment("Type of the seller")]
        [Required]
        [ForeignKey(nameof(TypeSellerId))]
        public TypeSeller TypeSeller { get; set; } = null!;

        [Comment("Seller's phone")]
        [Required]
        [MaxLength(SellerPhoneMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Comment("User identifier")]
        [Required]
        public string UserId { get; set; } = null!;

        [Comment("User")]
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public List<Car> Cars { get; set; } = new List<Car>();

        public List<Van> Vans { get; set; } = new List<Van>();

        public List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();

        public List<Truck> Trucks { get; set; } = new List<Truck>();
    }
}
