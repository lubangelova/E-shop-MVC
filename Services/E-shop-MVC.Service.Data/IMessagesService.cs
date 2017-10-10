using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Models;

namespace E_shop_MVC.Service.Data
{
    public interface IMessagesService
    {
        IQueryable<Message> GetAllMessages();

        void Add(Message message);

        void SaveChanges();
    }
}
