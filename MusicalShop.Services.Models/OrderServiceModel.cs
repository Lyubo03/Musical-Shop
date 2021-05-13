namespace MusicalShop.Services.Models
{
    using System;

    using MusicalShop.Data.Models;
    using MusicalShop.Services.Mapping;

    public class OrderServiceModel : IMapFrom<Cart>, IMapTo<Cart>
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public ProductServiceModel Product { get; set; }
        public DateTime IssuedOn { get; set; }
        public int Quantity { get; set; }
        public string IssuerId { get; set; }
        public MusicalShopUserServiceModel Issuer { get; set; }
        public int StatusId { get; set; }
        public OrderStatusServiceModel Status { get; set; }
    }
}