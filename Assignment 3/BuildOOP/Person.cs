using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Person : IPersonService
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void situation()
        {
            Console.WriteLine("good");
        }



        public int CalAge(int birthyear)
        {
            int result;
            int currentYear = DateTime.Now.Year;
            result = currentYear - birthyear;
            return result;
        }

        public decimal salary(int hour)
        {
            int result = (((hour * 7)* 4)*12);
            return result;
        }

        public string getaddress( string address)
        {
            Console.WriteLine("Enter your address");
            string s = Console.ReadLine();

            return s;
        }
    }



}
