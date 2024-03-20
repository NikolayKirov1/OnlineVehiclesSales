using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Type of gears")]
    public class GearsType
    {
        [Comment("Type identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of type of gears")]
        [Required]
        [MaxLength(GearsTypeNameMaxLength)]
        public string Name { get; set; } = null!;

        public List<Car> Cars { get; set; } = new List<Car>();

        public List<Van> Vans { get; set; } = new List<Van>();

        public List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();

        public List<Truck> Trucks { get; set; } = new List<Truck>();
    }
}
