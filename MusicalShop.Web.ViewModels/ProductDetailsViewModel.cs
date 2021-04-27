namespace MusicalShop.Web.ViewModels
{
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using System;

    public class ProductDetailsViewModel : IMapFrom<ProductServiceModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProductTypeName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Picture { get; set; }
        public DateTime ManufacturedOn { get; set; }
        public string Description { get; set; }
        public bool IsInStock { get; set; } = true;
    }
}