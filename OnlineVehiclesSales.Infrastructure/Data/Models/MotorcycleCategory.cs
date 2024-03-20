using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Motorcycle category")]
    public class MotorcycleCategory
    {
        [Comment("Motorcycle category identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Motorcycle category name")]
        [Required]
        [MaxLength(VehicleCategoryMaxLength)]
        public string Name { get; set; } = null!;

        public List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();
    }
}
