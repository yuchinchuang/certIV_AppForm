using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.ExceptionFolder
{
    public class MaxDailyWorkException: Exception
    {
        public MaxDailyWorkException():base("more than 24 hours")
        {

        }
    }
}
