using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3.Design_OOP.Entities
{
    public class Instructor : Person, IInstructorService
    {
        private int SalaryMultiplier { get; set; }
        private DateTime JoinDate { get; set; }
        public decimal BonusSalary()
        {
            DateTime thisDay = DateTime.Today;
            return (thisDay.Year - JoinDate.Year) * SalaryMultiplier;
        }

        public override decimal CalculateSalary()
        {

            return BonusSalary() + 100;
        }

    }
}
