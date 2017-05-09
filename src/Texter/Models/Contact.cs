using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Texter.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public void ConvertPhoneNumber(Contact contact)
        {
            var currentNumber = contact.PhoneNumber;
            contact.PhoneNumber = "+1" + currentNumber;
        }
    }

}
