using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Van category")]
    public class VanCategory
    {
        [Comment("Van category identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Van category name")]
        [Required]
        [MaxLength(VehicleCategoryMaxLength)]
        public string Name { get; set; } = null!;

        public List<Van> Vans { get; set; } = new List<Van>();
    }
}
