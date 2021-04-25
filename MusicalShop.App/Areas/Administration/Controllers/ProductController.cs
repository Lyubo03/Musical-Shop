namespace MusicalShop.App.Areas.Administration.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MusicalShop.Services;
    using MusicalShop.Services.Models;
    using MusicalShop.Web.InputModels.Product;
    using MusicalShop.Web.ViewModels;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ProductController : AdminController
    {
        private readonly IProductService productService;
        private readonly ICloudinaryService cloudinaryService;

        public ProductController(IProductService productService,
            ICloudinaryService cloudinaryService)
        {
            this.productService = productService;
            this.cloudinaryService = cloudinaryService;
        }
        public async Task<IActionResult> Create()
        {
            List<ProductTypeViewModel> productTypes = await productService.GetAllProductTypes()
                .Select(x => new ProductTypeViewModel
            {
                Name = x.Name
            }).ToListAsync();

            ViewData["types"] = productTypes;

            return this.View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateInputModel model)
        {
            if (!ModelState.IsValid)
            {
                var productTypes = await productService.GetAllProductTypes().Select(x => new ProductTypeViewModel
                {
                    Name = x.Name
                })
                    .ToListAsync();

                ViewData["types"] = productTypes;

                return this.View();
            }

            var pictureUrl = await this.cloudinaryService.UploadPictureAsync(model.Picture, model.Name);

            var productServiceModel = Mapper.Map<ProductServiceModel>(model);
            productServiceModel.Picture = pictureUrl;

            await productService.CreateProductAsync(productServiceModel);

            return this.Redirect("/");
        }

        [HttpGet("/Administration/Product/Type/Create")]
        public async Task<IActionResult> CreateType()
        {
            return this.View("Type/Create");
        }

        [HttpPost("/Administration/Product/Type/Create")]
        public async Task<IActionResult> CreateType(ProductTypeCreateInputModel model)
        {
            var productType = Mapper.Map<ProductTypeServiceModel>(model);
            await productService.CreateProductTypeAsync(productType);
            return this.Redirect("/");
        }
    }
}