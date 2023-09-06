using CyberGooseReviewV2.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CyberGooseReviewV2.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly DefaultContext db;

        public UserController(DefaultContext db)
        {
            this.db = db;
        }

    }
}
