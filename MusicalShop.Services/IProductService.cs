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
    }
}