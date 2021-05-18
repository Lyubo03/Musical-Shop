namespace MusicalShop.App.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MusicalShop.Services;
    using MusicalShop.Web.ViewModels.Home;
    using System.Linq;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        private const int NeededProductsToListHomePage = 10;
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await productService.GetAllProducts()
                .Select(x => Mapper.Map<ProductHomeViewModel>(x))
                .Take(NeededProductsToListHomePage)
                .ToListAsync();

            return View(products);
        }
    }
}