namespace MusicalShop.Services
{
    using Microsoft.EntityFrameworkCore;
    using MusicalShop.Data;
    using MusicalShop.Data.Models;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class CartService : ICartService
    {
        private readonly MusicalShopDbContext context;

        public CartService(MusicalShopDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddToCart(OrderServiceModel orderServiceModel)
        {
            var order = orderServiceModel.To<Cart>();
            order.Id = Guid.NewGuid().ToString();
            orderServiceModel.IssuedOn = DateTime.UtcNow;
            order.Status = await this.context.OrderStatuses.FirstOrDefaultAsync(status => status.Name == "Ordered");

            await context.AddAsync(order);
            var result = await context.SaveChangesAsync();

            return result > 0;
        }

        public IQueryable<OrderServiceModel> GetOrdersByUserId(string userId)
        {
            var orders = context.Cart
                .Include(x => x.Product)
                .Where(order => order.IssuerId == userId)
                .To<OrderServiceModel>();

            return orders;
        }
    }
}