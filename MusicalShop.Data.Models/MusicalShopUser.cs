namespace MusicalShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;

    public class MusicalShopUser : IdentityUser
    {
        public MusicalShopUser()
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}