namespace MusicalShop.Web.InputModels.Product
{
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    public class ProductCreateInputModel : IMapTo<ProductServiceModel>, IHaveCustomMappings
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ManufacturedOn { get; set; }

        public int Quantity { get; set; }

        [Required]
        public IFormFile Picture { get; set; }

        [Required]
        public string ProductType { get; set; }
        [Required]
        public string ProductBrand { get; set; }
        public string Description { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<ProductCreateInputModel, ProductServiceModel>()
                .ForMember(dest => dest.ProductType,
                opts => opts.MapFrom(origin => new ProductTypeServiceModel { Name = origin.ProductType }));

            configuration
                .CreateMap<ProductCreateInputModel, ProductServiceModel>()
                .ForMember(dest => dest.ProductBrand,
                opts => opts.MapFrom(origin => new ProductTypeServiceModel { Name = origin.ProductBrand }));
        }
    }
}