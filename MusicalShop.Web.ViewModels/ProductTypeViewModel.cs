namespace MusicalShop.Web.ViewModels
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;

    public class ProductTypeViewModel : IMapFrom<ProductTypeServiceModel>
    {
        public string Name { get; set; }
    }
}