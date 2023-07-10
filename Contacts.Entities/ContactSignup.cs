using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Entities
{
 public class ContactSignup
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string phoneNum1 { get; set; }
        public string phoneNum2 { get; set; }
        public string phoneNum3 { get; set; }
        public string adress { get; set; }
        public string  email { get; set; }
        public string website { get; set; }
        public string desc { get; set; }
        

        public override string ToString()
        {
            return name+" "+lastName;
        }

    }
}
