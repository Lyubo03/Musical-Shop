namespace MusicalShop.Web.InputModels.Checkout
{
    using System.ComponentModel.DataAnnotations;

    public class CheckoutInputModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
    }
}