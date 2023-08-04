using System.ComponentModel.DataAnnotations;

namespace CyberGooseReviewV2.Entity
{
    public class CategoriesSubCategories
    {
        [Key]
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
