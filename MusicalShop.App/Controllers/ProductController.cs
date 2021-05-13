namespace MusicalShop.App.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MusicalShop.Services;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using MusicalShop.Web.InputModels.Product;
    using MusicalShop.Web.ViewModels;
    using MusicalShop.Web.ViewModels.Shop;
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICartService orderService;

        public ProductController(IProductService productService,
            ICartService orderService)
        {
            this.productService = productService;
            this.orderService = orderService;
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

            model.IssuerId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var orderServiceModel = model.To<OrderServiceModel>();
            orderServiceModel.ProductId = model.Id;
            await orderService.AddToCart(orderServiceModel);

            return this.Redirect("/");
        }
    }
}