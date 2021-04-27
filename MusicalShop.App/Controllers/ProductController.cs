namespace MusicalShop.App.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MusicalShop.Services;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Web.ViewModels;
    using System.Threading.Tasks;

    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("Product/Details/{id?}")]
        public async Task<IActionResult> Details(string id)
        {
            var productDetailsViewModel = (await productService.GetProductByIdAsync(id)).To<ProductDetailsViewModel>();

            if (productDetailsViewModel.Quantity <= 0)
            {
                productDetailsViewModel.IsInStock = false;
            }

            return this.View(productDetailsViewModel);
        }
    }
}