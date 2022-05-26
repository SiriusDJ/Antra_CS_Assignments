using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3.Design_OOP.Entities
{
    public class Instructor : IInstructorService, IPersonService
    {
        public decimal BonusSalary()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAddresses()
        {
            throw new NotImplementedException();
        }

        public int GetAge()
        {
            throw new NotImplementedException();
        }
    }
}
