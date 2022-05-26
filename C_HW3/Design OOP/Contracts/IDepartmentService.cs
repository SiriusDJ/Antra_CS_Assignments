using C_HW3.Design_OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{

    public interface IDepartmentService 
    {
        Instructor GetHeadInstructor();
        Decimal GetBudget();
        List<Course> GetCourses();
    }


}
