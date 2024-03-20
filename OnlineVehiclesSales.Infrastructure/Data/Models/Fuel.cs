using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Type of fuel")]
    public class Fuel
    {
        [Comment("Fuel identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Fuel name")]
        [Required]
        [MaxLength(FuelNameMaxLength)]
        public string Name { get; set; } = null!;

        public List<Car> Cars { get; set; } = new List<Car>();

        public List<Van> Vans { get; set; } = new List<Van>();

        public List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();

        public List<Truck> Trucks { get; set; } = new List<Truck>();
    }
}
