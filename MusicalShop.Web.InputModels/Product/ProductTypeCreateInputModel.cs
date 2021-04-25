namespace MusicalShop.Web.InputModels.Product
{
    using MusicalShop.Services.Models;
    using MusicalShop.Services.Mapping;
    public class ProductTypeCreateInputModel : IMapTo<ProductTypeServiceModel>
    {
        public string Name { get; set; }
    }
}