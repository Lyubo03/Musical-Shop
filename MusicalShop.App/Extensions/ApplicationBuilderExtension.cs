namespace MusicalShop.App.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Data;
    using Data.Seeders;
    using System.Linq;
    using System.Reflection;

    public static class ApplicationBuilderExtension
    {
        public static void UseDatabaseSeeding(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<MusicalShopDbContext>())
                {
                    context.Database.Migrate();

                    var seeders = Assembly.GetAssembly(typeof(MusicalShopDbContext))
                       .GetTypes()
                       .Where(type => typeof(ISeeder).IsAssignableFrom(type))
                       .Where(type => type.IsClass)
                       .Select(type => (ISeeder)scope.ServiceProvider.GetRequiredService(type))
                       .ToList();

                   foreach(var seeder in seeders)
                   {
                        seeder.SeedAsync().GetAwaiter().GetResult();
                   }

                    context.SaveChangesAsync().GetAwaiter().GetResult();
                }
            }
        }

    }
}