namespace MusicalShop.Web.InputModels.Product
{
    using System.ComponentModel;

    public class ProductShopInputModel
    {
        [DisplayName("Criteria")]
        public string Criteria { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}