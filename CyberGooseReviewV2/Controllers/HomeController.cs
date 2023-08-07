﻿using AutoMapper;
using CyberGooseReviewV2.Context;
using CyberGooseReviewV2.Entity;
using CyberGooseReviewV2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace CyberGooseReviewV2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private DefaultContext db;

        public HomeController(DefaultContext db)
        {
            this.db = db;
        }

        // GET: HomeController
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SubCategory, SubCategoryModel>();
                cfg.CreateMap<Category, CategoryModel>();
            });
            var mapper = new Mapper(config);

            return db.Products.Include(c => c.Category).ToList().Select(p => new ProductModel()
            {
                Id = p.Id,
                Name = p.Name,
                YouTubeLink = p.YouTubeLink,
                Description = p.Description,
                CategoryId = p.CategoryId,
                Category = mapper.Map<CategoryModel>(p.Category),
                CommonRating = p.CommonRating,
                Country = p.Country,
                CriticRating = p.CriticRating,
                ProductPicture = p.ProductPicture,
                UserRating = p.UserRating,
                Year = p.Year,
                SubCategories = db.ProductSubCategories.Include(sc => sc.SubCategory).Include(p => p.Product)
                .Where(psc => psc.ProductId == p.Id).Select(psc => new SubCategoryModel() { Id = psc.Id, Name = db.SubCategories.FirstOrDefault(sc => sc.Id == psc.SubCategoryId).Name }).ToList()
            });
        }

    }
}
