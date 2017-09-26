using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Web.Infrastructure.Mapping;

namespace E_shop_MVC.Web.ViewModels.Home
{
    public class ProductViewModel : IMapFrom<Product>, IMapTo<Product>, IHaveCustomMappings
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Product, ProductViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}