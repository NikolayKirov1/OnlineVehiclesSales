using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineVehiclesSales.Infrastructure.Constants.DataConstants;

namespace OnlineVehiclesSales.Infrastructure.Data.Models
{
    [Comment("Type seller")]
    public class TypeSeller
    {
        [Comment("Tipe seller identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Type seller name")]
        [Required]
        [MaxLength(TypeSellerMaxLength)]
        public string Name { get; set; } = null!;

        public List<Seller> Sellers { get; set; } = new List<Seller>();
    }
}
