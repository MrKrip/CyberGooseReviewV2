using System.ComponentModel.DataAnnotations;

namespace CyberGooseReviewV2.Entity
{
    public class UserLikes
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool? Likes { get; set; }
    }
}
