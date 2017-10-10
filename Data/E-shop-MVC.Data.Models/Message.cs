using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Common.Models;

namespace E_shop_MVC.Data.Models
{
    public class Message: BaseModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string RecipientId { get; set; }

        public virtual ApplicationUser Recipient { get; set; }
    }
}
