namespace MusicalShop.Web.ViewModels.Order
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;

    public class CartViewModel : IMapFrom<OrderServiceModel>
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPicture { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quntity { get; set; }
    }
}