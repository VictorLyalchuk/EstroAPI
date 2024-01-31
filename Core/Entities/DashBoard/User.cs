using Core.Entities.Site;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.DashBoard
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public Bag? Bag { get; set; }
    }
    //public class User 
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    [Required]
    //    public string FirstName { get; set; } = string.Empty;
    //    [Required]
    //    public string LasrName { get; set; } = string.Empty;
    //    [Required]
    //    [EmailAddress]
    //    public string Email { get; set; } = string.Empty;
    //    [EmailAddress]
    //    public string EmailСonfirmed { get; set; } = string.Empty;
    //    [Required]
    //    public string Password { get; set; } = string.Empty;
    //    public string Role { get; set; } = string.Empty;
    //    [Required]
    //    [Phone]
    //    public string Phone { get; set; } = string.Empty;
    //    [Required]
    //    public DateTime Birthday { get; set; }
    //    public ICollection<Order>? Orders { get; set; }
    //    public Bag? Bag { get; set; }
    //}
}
