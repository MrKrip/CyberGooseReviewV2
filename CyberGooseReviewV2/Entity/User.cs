using Microsoft.AspNetCore.Identity;

namespace CyberGooseReviewV2.Entity
{
    public class User : IdentityUser
    {
        public string UserNick { get; set; }
        public string Salt { get; set; }
        public string Tag { get; set; }
        public DateTime? RegistationDate { get; set; }
        public byte[] ProfilePicture { get; set; } = null!;
    }
}
