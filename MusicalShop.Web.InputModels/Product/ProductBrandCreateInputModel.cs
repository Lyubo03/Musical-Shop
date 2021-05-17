namespace MusicalShop.Web.InputModels.Product
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    public class ProductBrandCreateInputModel : IMapTo<ProductBrandServiceModel>
    {
        public string Name { get; set; }
    }
}