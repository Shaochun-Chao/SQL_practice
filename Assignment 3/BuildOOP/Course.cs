using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Course: ICourseService
    {
        public string Name { get; set; }
        private int _courseId;
        
        public int CourseId
        {
            get { return _courseId; }
            private set { _courseId = value; }
        }

        public void cId()
        {
            CourseId = 101;
        }

        public string[] StudentList(int total)
        {
            string[] students = new string[total];
            for (int i = 0; i < total; i++)
            {
                Console.Write("enter coursename: ");
                students[i] = Console.ReadLine();
            }
            return students;
        }
    }
}
