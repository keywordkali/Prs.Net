using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Prs.Net.Models
{
    [Index(nameof(PartNumber), IsUnique = true)]
    public class Product
    {
        public int Id { get; set; } = 0;
        [StringLength(30), Required]
        public int VendorId { get; set; } = 0;
        public virtual Vendor Vendor { get; set; } = null;
        public string PartNumber { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; } = 0;
        public string Unit { get; set; } = string.Empty;
        [StringLength(30)]
        public string Photopath { get; set; } = string.Empty;






        public Product()
        {
        }
    }
}
