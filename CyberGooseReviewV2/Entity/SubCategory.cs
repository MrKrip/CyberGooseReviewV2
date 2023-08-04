using System.ComponentModel.DataAnnotations;

namespace CyberGooseReviewV2.Entity
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
