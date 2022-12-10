using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NETIntro.Core.Data.Models
{
    [Comment("Products to sell")]
    public class Product
    {
        [Key]
        [Comment("Primery key")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("Product name")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Product price")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Product quantity")]
        public int Quantity { get; set; }

        [Comment("Product is active")]
        public bool IsActive { get; set; } = true;
    }
}
