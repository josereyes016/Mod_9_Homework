using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string city;

        public Student(string firstName, string lastName, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
