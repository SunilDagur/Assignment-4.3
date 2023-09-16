using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._3
{
    using System;

    class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public string FullNameInUpperCase
        {
            get
            {
                
                return $"{FirstName} {LastName}".ToUpper();
            }
        }

        
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Program
    {
        static void Main()
        {
            
            Person person = new Person("Sunil", "Dagur");

            
            string fullNameUpperCase = person.FullNameInUpperCase;

            
            Console.WriteLine("Full Name in Uppercase: " + fullNameUpperCase);
        }
    }

}
