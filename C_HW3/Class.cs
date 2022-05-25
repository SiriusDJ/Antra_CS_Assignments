using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{
    public abstract class Person: IPersonService
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }

        public List<string> Address { get; set; }
        public void calculate_age()
        {
            Console.WriteLine(Age);
        }
        public virtual void salaryCalculation()
        {
            if (Salary >= 0)
            {
                Console.WriteLine($"Your salary is {Salary} dollars per week.");
            }
            else
            {
                Console.WriteLine("Salary is mistaken");
            }
        
        }

        public void getAddress()
        {
            if (Address[0] != string.Empty)
            {
                Console.WriteLine(Address[0]);
            }
        }

        
        public abstract void behavior();

    }
    public class Student: Person
    {
        public override void behavior()
        {
            Console.WriteLine("Go to learn");
        }

        public override void salaryCalculation()
        {
            Console.WriteLine("You do not have any salary.");
        }
    }
    public class Instructor: Person
    {
        public override void behavior()
        {
            Console.WriteLine("Go to teach");
        }
    }




}
