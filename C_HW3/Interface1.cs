using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{

    public interface IPersonService 
    {
        public void calculate_age();
        public void salaryCalculation();

        public void getAddress();

 
    }
    interface ICourseService { }
    interface IStudentService : IPersonService 
    {
        public void getGPA();
    }
    interface IInstructorService : IPersonService 
    {
    }
    interface IDepartmentService 
    {
    }


}
