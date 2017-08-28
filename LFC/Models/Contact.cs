using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFC.Models
{
    public class Contact
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string City{ get; set; }
        public string State{ get; set; }
        public string Zip{ get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}