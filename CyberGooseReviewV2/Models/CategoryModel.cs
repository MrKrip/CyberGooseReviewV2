﻿namespace CyberGooseReviewV2.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SubCategoryModel> subCategories { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
