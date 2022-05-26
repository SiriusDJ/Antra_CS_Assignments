using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{

    public interface IInstructorService : IPersonService 
    {
        decimal BonusSalary();
    }

}
