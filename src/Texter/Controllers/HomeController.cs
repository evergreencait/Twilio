using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Texter.Models;

namespace Texter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        }

        public IActionResult SendMessage()
        {
            Message model = new Message();
            model.To = "+12063217227";
            model.From = "+12065391227";
            return View(model);
        }

        [HttpPost]
        public IActionResult SendMessage(Message newMessage)
        {
            newMessage.Send();
            return RedirectToAction("Index");
        }
    }
}
