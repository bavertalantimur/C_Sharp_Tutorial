using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    internal class Property
    {
        private int id = 5;

        public int age { get; set; }
        
        private int tc = 6;
        public int StudentId
        {
            get { return id; }
            set { id = value; }
        }


    }
}
