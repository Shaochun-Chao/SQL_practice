using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Student:Person, IStudentService
    {

        public int Totalcourse { get; set; }

        private string _StudentId;

        private string _SchoolName;

        public string studentid
        {
            get { return _StudentId; }
            set { _StudentId = value; }
        }


        public string schoolname
        {
            get { return _SchoolName; }
            private set { _SchoolName = value; }
        }

        public void sName()
        {
            _SchoolName = "Antra";
        }


        public void situation(string sit)
        {
            Console.WriteLine($"I'm doing {sit}");
        }

        public string[] coursesName(int total)
        {
            string[] courses = new string[total];
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write("enter coursename: ");
                courses[i] =Console.ReadLine();
            }
            return courses;
            
        }

        public double Gpa()
        {
            Console.WriteLine("for gpa caluate");
            return -1;
        }
    }
}
