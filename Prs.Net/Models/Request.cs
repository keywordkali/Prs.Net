using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prs.Net.Models
{
    public class Request
    {
        public int Id { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public virtual User User { get; set; } = null;
        [StringLength(80),Required]
        public string Description { get; set; } = string.Empty;
        [StringLength(80)]
        public string Justification { get; set; } = string.Empty;
        public DateTime DateNeeded { get; set; } = DateTime.Today;
        [StringLength(30)]
        public string DeliveryMode { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Status { get; set; } = "New";
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; } = 0;
        public DateTime SubmittedDate { get; set; } = DateTime.Today;
        public string ReasonForRejection { get; set; } = string.Empty;

        public Request()
        {
        }
    }
public static class StatusValues
    {
        public static string New = "NEW";
        public static string Edit = "EDIT";
        public static string Review = "REVIEW";
        public static string Approved = "APPROVED";
        public static string Rejected = "REJECTED";
    }
}

