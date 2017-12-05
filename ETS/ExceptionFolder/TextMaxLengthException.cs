using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.ExceptionFolder
{
    class TextMaxLengthException : Exception
    {
        public TextMaxLengthException():base("over max length of text")
        {

        }
    }
}
