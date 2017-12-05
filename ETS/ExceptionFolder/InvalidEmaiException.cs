using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.ExceptionFolder
{
    public class InvalidEmaiException:Exception
    {
        public InvalidEmaiException():base("invalid email address format")
        {

        }
    }
}
