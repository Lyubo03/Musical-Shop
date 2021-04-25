namespace MusicalShop.Services
{
    using AutoMapper;
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

        public IQueryable<ProductTypeServiceModel> GetAllProductTypes()
        {
            var productTypes = context.ProductTypes.To<ProductTypeServiceModel>();

            return productTypes;
        }
    }
}