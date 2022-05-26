using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3.Design_OOP.Entities
{
    public class Person : IPersonService
    {
        public virtual decimal CalculateSalary()
        {
            return 100;
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
