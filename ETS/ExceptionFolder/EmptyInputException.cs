﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.ExceptionFolder
{
    public class EmptyInputException: Exception
    {
        public EmptyInputException():base("empty input")
        {

        }
    }
}
