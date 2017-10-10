using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Web.Infrastructure.Mapping;

namespace E_shop_MVC.Web.ViewModels.Message
{
    public class MessageViewModel : IMapFrom<E_shop_MVC.Data.Models.Message>, IMapTo<E_shop_MVC.Data.Models.Message>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public ApplicationUser Recipient { get; set; }

        public ApplicationUser Sender { get; set; }
    }
}