using _221031_Lesson.Areas.Admin.ViewModels.Product;
using _221031_Lesson.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _221031_Lesson.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var Model = new ProductIndexViewModel
            {
                Products = await _appDbContext.Products.ToListAsync()
            };
           return View(Model);
        }
    }
}
