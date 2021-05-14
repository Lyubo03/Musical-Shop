namespace MusicalShop.Web.ViewModels.Wishlist
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    public class WishlistViewModel : IMapFrom<ProductServiceModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}