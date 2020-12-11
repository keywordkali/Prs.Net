using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Prs.Net.Models
{
    [Index(nameof(Code), IsUnique = true)]

    public class Vendor
    {
        public int Id { get; set; } = 0;
        [StringLength(30), Required]
        public string Code { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string? Name { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Address { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string City { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string State { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Zip { get; set; } = string.Empty;
        [StringLength(30)]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
       


        public Vendor()
        {
        }
    }
}
