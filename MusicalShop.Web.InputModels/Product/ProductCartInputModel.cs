namespace MusicalShop.Web.InputModels.Product
{
    using System.ComponentModel.DataAnnotations;

    public class ProductCartInputModel
    {
        public string Id { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; } = 1;
    }
}