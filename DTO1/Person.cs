using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   
   public class Person
    {
        private string firstname, lastname;
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        
        public string Firstname {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname { 
            get {
                return lastname;
                 }
            set {
                lastname = value;
            } 
        }
        public override string ToString()
        {
            return "First name :"+ firstname+ ", Last name: "+lastname +".";
        }

    }
}
