namespace MusicalShop.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using MusicalShop.Data;
    using MusicalShop.Data.Models;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using System.Linq;
    using System.Threading.Tasks;
    public class ProductService : IProductService
    {
        private readonly MusicalShopDbContext context;

        public ProductService(MusicalShopDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> CreateProductAsync(ProductServiceModel model)
        {
            var product = Mapper.Map<Product>(model);

            await context.Products.AddAsync(product);
            var result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> CreateProductTypeAsync(ProductTypeServiceModel model)
        {
            var productType = Mapper.Map<ProductType>(model);

            await context.ProductTypes.AddAsync(productType);
            var result = await context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteProductByIdAsync(string id)
        {
            var product = await context.Products.SingleOrDefaultAsync(x => x.Id == id);

            context.Products.Remove(product);
            var result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> EditProductAsync(string id, ProductServiceModel model)
        {
            var productypeFromDb = await context.ProductTypes.FirstOrDefaultAsync(x => x.Name == model.ProductType.Name);


            var productFromDb = await context.Products.SingleOrDefaultAsync(x => x.Id == id);

            if (model.Picture != null)
            {
                productFromDb.Picture = model.Picture;
            }
            productFromDb.Name = model.Name;
            productFromDb.Price = model.Price;
            productFromDb.ProductType = productypeFromDb;
            productFromDb.Quantity = model.Quantity;
            productFromDb.ManufacturedOn = model.ManufacturedOn;
            productFromDb.Description = model.Description;

            var result = await context.SaveChangesAsync();
            return result > 0;
        }

        public IQueryable<ProductServiceModel> GetAllProducts()
        {
            var products = context.Products.To<ProductServiceModel>();
            return products;
        }

        public IQueryable<ProductTypeServiceModel> GetAllProductTypes()
        {
            var productTypes = context.ProductTypes.To<ProductTypeServiceModel>();

            return productTypes;
        }

        public async Task<ProductServiceModel> GetProductByIdAsync(string id)
        {
            var product = await this.context.Products.To<ProductServiceModel>()
                .SingleOrDefaultAsync(x => x.Id == id);

            return product;
        }
    }
}