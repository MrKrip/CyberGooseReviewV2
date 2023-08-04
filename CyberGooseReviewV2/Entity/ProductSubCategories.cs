﻿using System.ComponentModel.DataAnnotations;

namespace CyberGooseReviewV2.Entity
{
    public class ProductSubCategories
    {
        [Key]
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
