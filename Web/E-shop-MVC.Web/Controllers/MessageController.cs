using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Service.Data;
using E_shop_MVC.Web.Infrastructure.Mapping;
using E_shop_MVC.Web.InputModels.Message;
using E_shop_MVC.Web.ViewModels.Message;
using Microsoft.AspNet.Identity;

namespace E_shop_MVC.Web.Controllers
{
    public class MessageController: BaseController
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

        public ActionResult AddMessageToDb(MessageInputModel input)
        {
            var userId = this.User.Identity.GetUserId();
            var message = new Message
            {
                RecipientId = userId,
                Title = input.Title,
                Content = input.Content
            };

            this.messages.Add(message);
            this.messages.SaveChanges();
            return this.RedirectToAction("Index", new { id = message.Id, url = "new" });
        }
    }
}