using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_shop_MVC.Web.ViewModels.Message
{
    public class IndexViewModel
    {
        public ICollection<MessageViewModel> Messages { get; set; }
    }
}