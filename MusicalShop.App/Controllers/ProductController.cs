namespace MusicalShop.App.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using MusicalShop.Services;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Web.InputModels.Product;
    using MusicalShop.Web.ViewModels;
    using MusicalShop.Web.ViewModels.Shop;
    using System;
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

        public async Task<IActionResult> Shop()
        {
            var products = productService.GetAllProducts().To<ProductShopViewModel>();

            var productTypes = productService.GetAllProductTypes().To<ProductTypeViewModel>();
            ViewData["types"] = productTypes;

            return this.View(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromForm] ProductCartInputModel model)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Identity/Account/Register");
            }

            var key = "product" + Guid.NewGuid().ToString();
            var value = $"Id:{model.Id} Qty:{model.Quantity}";
            var cookieOpts = new CookieOptions();
            cookieOpts.Expires = DateTime.UtcNow.AddDays(7);
            var cookie = Request.Cookies[key];
            
            Response.Cookies.Append(key, value, cookieOpts);

            return this.Redirect("/");
        }

        [HttpGet("Product/Wishlist/{id?}")]
        public async Task<IActionResult> AddToWishlist(string id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Identity/Account/Register");
            }

            var key = "wish" + Guid.NewGuid().ToString();
            var value = id;
            var cookieOpts = new CookieOptions();
            cookieOpts.Expires = DateTime.UtcNow.AddDays(7);
            var cookie = Request.Cookies[key];

            Response.Cookies.Append(key, value, cookieOpts);

            return this.Redirect("/");
        }
    }
}