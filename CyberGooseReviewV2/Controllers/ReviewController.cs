using CyberGooseReviewV2.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CyberGooseReviewV2.Models;
using AutoMapper;

namespace CyberGooseReviewV2.Controllers
{
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly DefaultContext db;

        public ReviewController(DefaultContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("reviews/{id}")]
        public IEnumerable<ReviewModel> Get(int id)
        {
            var reviews = db.Reviews.Where(r => r.ProductId == id);

            var result = reviews.Select(r => new ReviewModel()
            {
                ProductId = r.ProductId,
                CreationDate = r.CreationDate,
                Details = r.ReviewDetails,
                DisLikes = r.DisLikes,
                Likes = r.Likes,
                ProductName = r.Product.Name,
                Rating = r.Rating,
                userData = db.Users.Where(u => u.Id == r.UserId).Select(u => new UserDataModel()
                {
                    Id = u.Id,
                    Email = u.Email,
                    ProfilePicture = u.ProfilePicture,
                    RegistationDate = u.RegistationDate,
                    Salt = u.Salt,
                    Tag = u.Tag,
                    UserName = u.UserName,
                    UserNick = u.UserNick
                }).First()
            }).ToList();
            foreach (var review in result) { 
                var prod = db.Products.First(p=>p.Id == review.ProductId);
                var CatRoles=db.CategoryRoles.Where(cr=>cr.CategoryId==prod.CategoryId).ToList();
                List<string> roles = new List<string>();
                foreach (var category in CatRoles)
                {
                    roles.Add(db.Roles.Where(r => r.Id == category.RoleID).Select(r => r.Name).First());
                }
                review.userData.Roles = roles;
            }
            return result;
        }
    }
}
