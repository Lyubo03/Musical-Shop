namespace MusicalShop.Web.InputModels.Product
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    public class ProductTypeCreateInputModel : IMapTo<ProductTypeServiceModel>
    {
        public string Name { get; set; }
    }
}