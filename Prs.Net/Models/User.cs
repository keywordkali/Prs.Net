using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Prs.Net.Models
{
    [Index(nameof(UserName), IsUnique = true)]

    public class User
    {
        public int Id { get; set; } = 0;
        [StringLength(30), Required]
        public string UserName { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Password { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string LastName { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [StringLength(30)]
        public string Email { get; set; } = string.Empty;
        public bool IsReviewer { get; set; } = false;
        public bool IsAdmin { get; set; } = false;

        public User()
        {
        }
    }
}

