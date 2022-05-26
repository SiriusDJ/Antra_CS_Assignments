using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3.Design_OOP.Entities
{
    public class Student : Person, IStudentService
    {
        private List<Course> CourseList { set; get; }
   
        

        public double CalculateGPA()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourses()
        {
            return CourseList;
        }

        public override decimal CalculateSalary()
        {
            return 0;
        }


    }
}
