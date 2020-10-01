/*Author: Lam Nguyen
 * Date: 09/29/2020
 * Description: This is the model for the Person
 * */
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName} {Phone}";
            }
        }
    }
}
