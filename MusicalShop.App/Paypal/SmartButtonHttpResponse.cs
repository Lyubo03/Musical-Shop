/*namespace MusicalShop.App.Paypal
{
    using PayPalCheckoutSdk.Orders;
    using System.Net;
    using System.Net.Http.Headers;
    public class SmartButtonHttpResponse
    {
         readonly Order _result;
        public SmartButtonHttpResponse(PayPalHttp.HttpResponse httpResponse)
        {
            Headers = httpResponse.Headers;
            StatusCode = httpResponse.StatusCode;
            _result = httpResponse.Result<Order>();
        }

        public HttpHeaders Headers { get; }
        public HttpStatusCode StatusCode { get; }

        public Order Result()
        {
            return _result;
        }

        public string orderID { get; set; }
    }
}*/