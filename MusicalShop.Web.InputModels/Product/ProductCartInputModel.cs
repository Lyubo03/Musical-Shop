namespace MusicalShop.Web.InputModels.Product
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using System.ComponentModel.DataAnnotations;

    public class ProductCartInputModel : IMapTo<OrderServiceModel>
    {
        public string Id { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        public string IssuerId { get; set; }
    }
}