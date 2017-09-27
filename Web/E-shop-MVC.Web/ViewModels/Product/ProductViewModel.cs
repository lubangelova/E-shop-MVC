using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Web.Infrastructure.Mapping;

namespace E_shop_MVC.Web.ViewModels.Product
{
    public class ProductViewModel : IMapFrom<E_shop_MVC.Data.Models.Product>, IMapTo<E_shop_MVC.Data.Models.Product>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<E_shop_MVC.Data.Models.Product, ProductViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}