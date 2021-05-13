namespace MusicalShop.App.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MusicalShop.Services;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Web.ViewModels.Order;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class CartController : Controller
    {
        private readonly ICartService orderService;

        public CartController(ICartService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<IActionResult> Cart()
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Identity/Account/Register");
            }

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var orders = orderService.GetOrdersByUserId(userId).To<CartViewModel>();
            return this.View(orders);
        }
        public async Task<IActionResult> Checkout()
        {
            return this.View();
        }
    }
}