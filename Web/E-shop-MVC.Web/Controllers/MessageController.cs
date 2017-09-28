using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_shop_MVC.Service.Data;
using E_shop_MVC.Web.Infrastructure.Mapping;
using E_shop_MVC.Web.ViewModels.Message;

namespace E_shop_MVC.Web.Controllers
{
    public class MessageController: Controller
    {
        private IMessagesService messages;
        public MessageController(IMessagesService messages)
        {
            this.messages = messages;
        }

        public ActionResult Index()
        {
            var messages = this.messages.GetAllMessages()
            .To<MessageViewModel>()
            .ToList();
            var viewModel = new IndexViewModel
            {
                Messages = messages
            };
            return View(viewModel);
        }
    }
}