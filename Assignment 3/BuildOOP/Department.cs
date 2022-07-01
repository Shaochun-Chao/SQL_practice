using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Department: IDepartment
    {
        private string Headname;
        public string headname
        {
            get { return Headname; }    
            set { Headname = value; }
        }

        private DateTime start;
        private DateTime end;
        public DateTime Start
        {
            get { return start; }
            set { start = value; }

        }
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }

        public void PrintCourse()
        {
            string[] coursename = new string[10];
            foreach(var item in coursename)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
