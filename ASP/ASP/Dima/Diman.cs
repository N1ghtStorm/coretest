using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Dima
{
    public class Diman
    {
        private String name;
        private String lastName;

        public Diman()
        {
            name = "Dima";
            lastName = "Bushuev";
        }

        public List<string> ShowMyName()
        {
            var result = new List<string> (){ name, lastName }; 
            return result;
        }
    }
}
