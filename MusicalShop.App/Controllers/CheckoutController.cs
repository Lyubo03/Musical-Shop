namespace MusicalShop.App.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MusicalShop.Web.InputModels.Checkout;
    using System.Threading.Tasks;

    public class CheckoutController : Controller
    {
        public CheckoutController()
        {

        }
        /*[HttpPost]
        public async Task<IActionResult> Checkout(CheckoutInputModel model)
        {
        }*/
        public IActionResult Index()
        {
#if DEBUG
            // You may want to create a UAT (user exceptance tester) role 
            // and check for this:
            // "if(_unitOfWork.IsUATTester(GetUserId())"
            // Company SANDBOX Client Id. To go live replace this with the live ID.
            /*ViewBag.ClientId =
            <alert > PayPal.PayPalClient.SandboxClientId </ alert >; */// Get from a 
                                                                      // data store or stettings
#else
            // Company LIVE Client Id. To go live replace this with the live ID.
            ViewBag.ClientId = 
            <alert>PayPal.PayPalClient.LiveClientId</alert>; // Get from a 
                                                       // data store or stettings
#endif

            ViewBag.CurrencyCode = "USD"; // Get from a data store
            ViewBag.CurrencySign = "$";   // Get from a data store

            return View();
        }

        /// <summary>
        /// This action is called when the user clicks on the PayPal button.
        /// </summary>
        /// <returns></returns>
        /*[Route("api/paypal/checkout/order/create")]
        public async Task<SmartButtonHttpResponse> Create()
        {
            var request = new PayPalCheckoutSdk.Orders.OrdersCreateRequest();

            request.Prefer("return=representation");
            request.RequestBody(OrderBuilder.Build());

            // Call PayPal to set up a transaction
            var response = await PayPalClient.Client().Execute(request);

            // Create a response, with an order id.
            var result = response.Result<PayPalCheckoutSdk.Orders.Order>();
            var payPalHttpResponse = new SmartButtonHttpResponse(response)
            {
                orderID = result.Id
            };
            return payPalHttpResponse;
        }*/

        /// <summary>
        /// This action is called once the PayPal transaction is approved
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [Route("api/paypal/checkout/order/approved/{orderId}")]
        public IActionResult Approved(string orderId)
        {
            return Ok();
        }

        /// <summary>
        /// This action is called once the PayPal transaction is complete
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [Route("api/paypal/checkout/order/complete/{orderId}")]
        public IActionResult Complete(string orderId)
        {
            // 1. Update the database.
            // 2. Complete the order process. Create and send invoices etc.
            // 3. Complete the shipping process.
            return Ok();
        }

        /// <summary>
        /// This action is called once the PayPal transaction is complete
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [Route("api/paypal/checkout/order/cancel/{orderId}")]
        public IActionResult Cancel(string orderId)
        {
            // 1. Remove the orderId from the database.
            return Ok();
        }

        [Route("api/paypal/checkout/order/error/{orderId}/{error}")]
        public IActionResult Error(string orderId,
                                   string error)
        {
            return NoContent();
        }
    }
}