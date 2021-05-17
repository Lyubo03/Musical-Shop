namespace MusicalShop.Web.ViewModels
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    public class ProductBrandViewModel : IMapFrom<ProductBrandServiceModel>
    {
        public string Name { get; set; }
    }
}