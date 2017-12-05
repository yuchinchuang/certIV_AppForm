using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Entity
{
    public class EmpHour
    {
        public int EmpHourID { get; set; }
        public int EmpID { get; set; }
        public DateTime WorkDate { get; set; }
        public double Hour { get; set; }

        public string FullName { get; set; }
    }

}
