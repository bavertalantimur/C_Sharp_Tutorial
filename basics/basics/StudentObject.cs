using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    internal class StudentObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetFullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }
    }
}
