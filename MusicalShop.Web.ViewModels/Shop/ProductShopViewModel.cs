namespace MusicalShop.Web.ViewModels.Shop
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    public class ProductShopViewModel : IMapFrom<ProductServiceModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
    }
}