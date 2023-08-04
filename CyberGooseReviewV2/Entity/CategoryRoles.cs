using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CyberGooseReviewV2.Entity
{
    public class CategoryRoles
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string RoleID { get; set; }
        public IdentityRole Role { get; set; }
    }
}
