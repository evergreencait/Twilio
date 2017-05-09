using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Texter.Models;

namespace Texter.ViewModels
{
    public class SendMessageViewModel
    {
        public List<Contact> Contacts { get; set; }
        public Message Message { get; set; } 
    }
}
