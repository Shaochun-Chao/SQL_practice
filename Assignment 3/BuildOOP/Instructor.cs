using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Instructor : Person, IInstructorService
    {
        public Instructor(int id, string name, string departmentName, int salary)
        {
            Id = id;
            Name = name;
            DepartmentName = departmentName;
            Salary = salary;
            
        }
        public string DepartmentName { get; set; }
        public int Salary { get; set; } 

        private int _InstructorId;

        public int InstructorId
        {
            get { return _InstructorId; }
            set { _InstructorId = value; }
        }


        public  void situation(int a)
        {
            Console.WriteLine($"{a}% of day is happy");
        }

        public int BounsJoin(DateTime join)
        {
            DateTime current = DateTime.Now;
            TimeSpan result = current.Subtract(join);
            int total =(int) result.TotalDays;
            return total;
        }

        public bool HeadDepartment(int workyear)
        {
            if(workyear >= 25)
            {
                return true;
            }
            return false;
        }
    }
}
