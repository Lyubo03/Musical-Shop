namespace MusicalShop.App.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using global::Stripe;
    using MusicalShop.Web.InputModels.Checkout;
    using MusicalShop.Services;
    using AutoMapper;
    using MusicalShop.Services.Models;

    public class CheckoutController : Controller
    {
        private readonly IOrderService orderService;

        public CheckoutController(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        public async Task<IActionResult> Checkout(CheckoutInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            var order = Mapper.Map<OrderServiceModel>(model);
            order.OrderStatus.Name = "Ordered";
            order.IsCashOnDelivery = true;
            await orderService.Create(order);

            return this.Redirect("/Success");
        }
        public async Task<IActionResult> Charge(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = await customers.CreateAsync(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = await charges.CreateAsync(new ChargeCreateOptions
            {
                Amount = 500,
                Description = "Test Payment",
                Currency = "USD",
                Customer = customer.Id
            });

            if (charge.Status == "succeeded")
            {
                string balanceTransactionId = charge.BalanceTransactionId;
                this.Redirect("/Success");
            }

            return this.View("/Cart");
        }
    }
}