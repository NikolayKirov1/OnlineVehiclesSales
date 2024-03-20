using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Truck category")]
    public class TruckCategory
    {
        [Comment("Truck category identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Truck category name")]
        [Required]
        [MaxLength(VehicleCategoryMaxLength)]
        public string Name { get; set; } = null!;

        public List<Truck> Trucks { get; set; } = new List<Truck>();
    }
}
