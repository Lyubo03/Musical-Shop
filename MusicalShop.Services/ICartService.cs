namespace MusicalShop.Services
{
    using MusicalShop.Services.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICartService
    {
        Task<bool> AddToCart(OrderServiceModel orderServiceModel);
        IQueryable<OrderServiceModel> GetOrdersByUserId(string userId);
    }
}