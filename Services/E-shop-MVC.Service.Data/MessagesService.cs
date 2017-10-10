using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Common;
using E_shop_MVC.Data.Models;

namespace E_shop_MVC.Service.Data
{
    public class MessagesService : IMessagesService
    {
        private IDbRepository<Message> messages;

        public MessagesService(IDbRepository<Message> messages)
        {
            this.messages = messages;
        }

        public void Add(Message message)
        {
            this.messages.Add(message);
        }

        public IQueryable<Message> GetAllMessages()
        {
            return this.messages.All()
               .OrderBy(x => x.Title);
        }

        public void SaveChanges()
        {
            this.messages.Save();
        }
    }
}
