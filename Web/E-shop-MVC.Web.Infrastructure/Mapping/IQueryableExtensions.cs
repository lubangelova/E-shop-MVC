using System;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;

namespace E_shop_MVC.Web.Infrastructure.Mapping
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TDestination> To<TDestination>(this IQueryable source, params Expression<Func<TDestination, object>>[] membersToExpand)
        {
            return source.ProjectTo(AutoMapperConfig.Configuration, membersToExpand);
        }
    }
}
