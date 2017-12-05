using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.ExceptionFolder
{
    public class PhoneDuplicatedException:Exception
    {
        public PhoneDuplicatedException():base("Phone number already existed")
        {

        }
    }
}
