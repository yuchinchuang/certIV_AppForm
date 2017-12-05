using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.DataAccess
{
    public static class DataHelper
    {
        public static string GetConnecctionString()
        {
            return "Data Source=.\\SQLEXPRESS;Initial Catalog=EmpDatabase;Integrated Security=True";
            //return "Data Source=PEA106-04;Initial Catalog=EmpDatabase;User ID=sa;Password= Petersham";
        }
    }
}
