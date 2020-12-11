using System;
using System.Text.Json.Serialization;

namespace Prs.Net.Models
{
    public class LineItem
    {
        public int Id { get; set; } = 0;
        public int RequestId { get; set; } = 0;
        [JsonIgnore]
        public virtual Request Request { get; set; } = null;
        public int ProductId { get; set; } = 0;
        public virtual Product Product { get; set; }= null;
        public int Quantity { get; set; } = 0;
        public LineItem()
        {
        }
    }
}
