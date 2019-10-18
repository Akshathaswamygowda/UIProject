using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   internal class Utilities
    {
        public static string GetConnectionString()
        {
            return "data source=LAPTOP-TOTBIB0R\\SQLEXPRESS;initial catalog=Adopractice;integrated security=sspi";
        }
    }
}
