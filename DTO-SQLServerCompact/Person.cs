using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_SQLServerCompact
{
    public class Person
    {   public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
