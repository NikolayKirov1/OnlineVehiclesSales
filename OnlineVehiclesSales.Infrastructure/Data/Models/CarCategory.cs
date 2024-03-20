using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Car category")]
    public class CarCategory
    {
        [Comment("Car category identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Car category name")]
        [Required]
        [MaxLength(VehicleCategoryMaxLength)]
        public string Name { get; set; } = null!;

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
