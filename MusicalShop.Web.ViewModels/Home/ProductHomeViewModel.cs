namespace MusicalShop.Web.ViewModels.Home
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;

    public class ProductHomeViewModel : IMapFrom<ProductServiceModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
    }
}