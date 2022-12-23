using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_dataset
{
    internal class Contact
    {
        private string name;
        private string number;
        private string email;
        private string company;
        private string address;


        public Contact(string name, string number, string email, string company, string address)
        {
            this.name = name;
            this.number = number;
            this.email = email;
            this.company = company;
            this.address = address;
        }
        public Contact() { }

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }
        public string Company { get => company; set => company = value; }
        public string Address { get => address; set => address = value; }
    }
}
