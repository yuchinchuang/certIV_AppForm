using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.ExceptionFolder
{
    public class NoWorkHourException: Exception
    {
        public NoWorkHourException():base("negative or zero value of work hour")
        {

        }
    }
}
