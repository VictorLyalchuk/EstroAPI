using Core.Entities.DashBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Site
{
    public class Bag
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string IdsProduct { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }
        public string UserId { get; set; } = string.Empty;
        public User? Users { get; set; }
    }
}
