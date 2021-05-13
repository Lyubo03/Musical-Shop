namespace MusicalShop.Web.ViewModels.Order
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;

    public class ProductOrderViewModel : IMapFrom<ProductServiceModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Picture { get; set; }
    }
}