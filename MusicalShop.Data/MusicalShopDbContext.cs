﻿namespace MusicalShop.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MusicalShop.Data.Models;

    public class MusicalShopDbContext : IdentityDbContext<MusicalShopUser, IdentityRole, string>
    {
        public MusicalShopDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}