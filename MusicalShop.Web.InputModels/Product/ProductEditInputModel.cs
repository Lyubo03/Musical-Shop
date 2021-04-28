namespace MusicalShop.Web.InputModels.Product
{
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using MusicalShop.Services.Mapping;
    using MusicalShop.Services.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ProductEditInputModel : IMapFrom<ProductServiceModel>, IMapTo<ProductServiceModel>, IHaveCustomMappings
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ManufacturedOn { get; set; }
        public int Quantity { get; set; }

        public IFormFile Picture { get; set; }

        [Required]
        public string ProductType { get; set; }

        public string Description { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<ProductServiceModel, ProductEditInputModel>()
                .ForMember(destination => destination.Picture,
                            opts => opts.Ignore())
                .ForMember(destination => destination.ProductType,
                            opts => opts.MapFrom(origin => origin.ProductType.Name));

            configuration
                .CreateMap<ProductEditInputModel, ProductServiceModel>()
                .ForMember(destination => destination.ProductType,
                            opts => opts.MapFrom(origin => new ProductTypeServiceModel { Name = origin.ProductType }));
        }
    }
}