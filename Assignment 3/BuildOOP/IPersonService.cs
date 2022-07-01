using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
     interface IPersonService
    {
        public int CalAge(int birthyear);
        public decimal salary(int hour);

        public string getaddress(string add);

    }
}
