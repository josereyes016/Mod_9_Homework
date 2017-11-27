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

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName { get { return lastName; } }
        public string City { get { return city; } }

        public override string ToString()
        {
            string result = string.Format("{0} {1} from {2}", this.firstName, this.lastName, this.city);
            return result;
        }
    }
}
