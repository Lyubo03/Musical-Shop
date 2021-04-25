namespace MusicalShop.App
{
    using CloudinaryDotNet;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using MusicalShop.App.Extensions;
    using MusicalShop.Data;
    using MusicalShop.Data.Models;
    using MusicalShop.Data.Seeders;
    using MusicalShop.Services;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using MusicalShop.Web.InputModels.Product;
    using MusicalShop.Web.ViewModels;
    using System.Globalization;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MusicalShopDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<MusicalShopUser, IdentityRole>(options => options.User.RequireUniqueEmail = true)
                .AddEntityFrameworkStores<MusicalShopDbContext>()
                .AddDefaultTokenProviders();

            var cloudinaryCredentials = new Account(
               this.Configuration["Cloudinary:CloudName"],
               this.Configuration["Cloudinary:ApiKey"],
               this.Configuration["Cloudinary:ApiSecret"]);

            var cloudinaryUtility = new Cloudinary(cloudinaryCredentials);
            services.AddSingleton(cloudinaryUtility);

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
            });

            services.AddTransient<AdminSeeder>();
            services.AddTransient<RoleSeeder>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();

            //services.AddSingleton<IEmailSender, EmailSender>();

            services.AddRazorPages();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            AutoMapperConfig.RegisterMappings(typeof(ProductCreateInputModel).Assembly,
                typeof(ProductTypeServiceModel).Assembly,
                typeof(ProductTypeViewModel).Assembly);

            app.UseRouting();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseResponseCompression();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseDatabaseSeeding();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}