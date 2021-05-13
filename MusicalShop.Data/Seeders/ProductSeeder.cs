namespace MusicalShop.Data.Seeders
{
    using MusicalShop.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ProductSeeder : ISeeder
    {
        private readonly MusicalShopDbContext context;

        public ProductSeeder(MusicalShopDbContext context)
        {
            this.context = context;
        }
        public async Task SeedAsync()
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>()
            {
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 2589.99m,
                    Description = "The best acoustic Guitar ever existed!",
                    Name = "Lâg HyVibe THV30DCE",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1620935444/musical_shop_product_images/lag-tramontane-thv30dce-dreadnought-cutaway-hyvibe_dxsn5q.png",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-1),
                    ProductTypeId = 31,
                    Quantity = 121
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 4589.99m,
                    Description = "Wholesale New Arrival KH-20 Ouija Kirk Hammett Signature Electric Guitar Star Moon Inlay In Black 110520",
                    Name = "Kirk Hammett's ESP KH-2 Ouija guitar",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632570/musical_shop_product_images/u5luo3a40yq6xg8l5xh3.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-10),
                    ProductTypeId = 32,
                    Quantity = 36
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 119.99m,
                    Description = "Price quality convinient!",
                    Name = "Ukulele",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632532/musical_shop_product_images/gdkgnu8tw0ee0ebblay3.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddMonths(-1),
                    ProductTypeId = 33,
                    Quantity = 100
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 199.99m,
                    Description = "Fender ukulele!",
                    Name = "Fender Ukulele",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632408/musical_shop_product_images/t3vmvilc98fftgavtt7r.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-1),
                    ProductTypeId = 33,
                    Quantity = 55
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 3136.99m,
                    Description = "V-Drums Acoustic Design is a brand-new V-Drums experience, blending the physical presence of acoustic drums with Roland’s world-leading digital percussion technology. The Roland VAD506 is a five-piece V-Drums Acoustic Design kit with full-size wood shells and flagship-class sound. The digital snare and ride pads connect to the TD-27 module via USB cables, working together with the sound engine to deliver the most natural expression, allowing your drumming skills to be heard in incredible detail.",
                    Name = "Acoustic Drums",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632446/musical_shop_product_images/qrs9cilcayb9i8oilrcd.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-1).AddMonths(-5),
                    ProductTypeId = 36,
                    Quantity = 65
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 17324.99m,
                    Description = "Among pianos, each size possesses a unique character with distinctive tonal qualities. The impressive tone of the 5’2″ GL-20 baby grand piano is enhanced not only by its longer scale design that provides more bass response, but also by the addition of Dual Duplex Scaling that allows the extreme ends of the piano’s strings to vibrate and produce additional harmonics that enliven tone. Dual Duplex Scaling is an important design element that helps make possible the beautiful singing quality of the GL-20.",
                    Name = "KAWAI GL20",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632479/musical_shop_product_images/ppu0wj4mntqnrptypqdy.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-4).AddDays(-2),
                    ProductTypeId = 34,
                    Quantity = 22
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 2589.99m,
                    Description = "For the go-anywhere acoustic performer who needs ultra-compact convenience at a moment’s notice, the Acoustasonic 15 is just the right small amp with just the right sound. Perfectly portable, it delivers great tone and features for an acoustic guitar and a mic—ideal simplicity and flexibility for a variety of musical and basic public address uses at small gigs and gatherings.",
                    Name = "Violin",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632375/musical_shop_product_images/yuudpwcps7pm0ncm5pdt.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-1),
                    ProductTypeId = 38,
                    Quantity = 72
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 249.17m,
                    Description = "Fender presents with the Malibu Player, an electro-acoustic guitar with short pitch, easy to play, with solid spruce top, with fun colors. The format and enjoyment of the game will make the Malibu Player, the guitar on which you can spend hours playing new chords, new melodies ... Here in its finish Aqua Splash! © SonoVente.com :https://www.sonovente.com/en-gb/fender-malibu-player-aqua-splash-p60822.html",
                    Name = "MALIBU PLAYER AQUA SPLASH - FENDER",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1620936966/musical_shop_product_images/baavjuwcvphjz5na2ihc_gtcim9.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-1),
                    ProductTypeId = 31,
                    Quantity = 223
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 42.00m,
                    Description = "Add more variety to your guitar playing! Capos are the essential tool for playing in different keys and adjusting your sound to different vocal pitches. They are suitable for guitarists of all levels, from beginners to professionals. The Kyser Quick-Change Capo is made of strong, light-weight aluminum. The spring-tensioned Quick-Change clamps firmly to hold intonation, but is quickly and easily released and repositioned without disturbing the tuning. You can operate your Quick-Change comfortably with one hand. You'll find that it doesn't interfere with fingering and the pads won't mark or react with guitar finishes.",
                    Name = "Kyser KG6S Quick-Change Acoustic Guitar Capo - Silver",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1620935444/musical_shop_product_images/lag-tramontane-thv30dce-dreadnought-cutaway-hyvibe_dxsn5q.png",
                    ManufacturedOn = DateTime.UtcNow.AddMonths(-3),
                    ProductTypeId = 35,
                    Quantity = 213
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 2589.99m,
                    Description = "The best electric Guitar ever existed!",
                    Name = "Electric Guitar",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632285/musical_shop_product_images/i2u2i1pwenbbhhp6hbnx.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-1),
                    ProductTypeId = 32,
                    Quantity = 15
                },new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Price = 850.00m,
                    Description = "The 20-watt Champion 20 features a single 8' Special Design speaker, with great amp voices and effects that make it easy to dial up just the right sound-from jazz to country, blues to metal and more.",
                    Name = "FENDER CHAMPION 20W ELECTRIC GUITAR AMPLIFIER",
                    Picture = "https://res.cloudinary.com/dnbwy7p6f/image/upload/v1620936659/musical_shop_product_images/0002110_fender-champion-20w-electric-guitar-amplifier_400_qwbeg3.jpg",
                    ManufacturedOn = DateTime.UtcNow.AddYears(-1).AddMonths(-6),
                    ProductTypeId = 35,
                    Quantity = 163
                },
            };
                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();
            }
        }
    }
}