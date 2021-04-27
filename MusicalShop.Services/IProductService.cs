namespace MusicalShop.Services
{
    using MusicalShop.Services.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IProductService
    {
        Task<bool> CreateProductTypeAsync(ProductTypeServiceModel model);
        Task<bool> CreateProductAsync(ProductServiceModel model);
        IQueryable<ProductTypeServiceModel> GetAllProductTypes();
        IQueryable<ProductServiceModel> GetAllProducts();
        Task<ProductServiceModel> GetProductByIdAsync(string id);
        Task<bool> DeleteProductByIdAsync(string id);
        Task<bool> EditProductAsync(ProductServiceModel model);
    }
}