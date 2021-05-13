namespace MusicalShop.Data.Models
{
    using System;

    public class Cart : BaseModel<string>
    {
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime IssuedOn { get; set; }
        public int Quantity { get; set; }
        public string IssuerId { get; set; }
        public MusicalShopUser Issuer { get; set; }
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; }
    }
}