using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using System.Data.SqlClient;

namespace ETS.DataAccess
{
    public class EmpHoursDao
    {
        public void CreateWork(EmpHours aEmpHour)
        {
            //step 1: create connection the object
            SqlConnection conn = new SqlConnection();

            //step 2: assign the connection string
            conn.ConnectionString = "Data Source=PEA104-18;Initial Catalog=EmpDatabase;User ID=sa;Password=Petersham";
            
            //step 3: open the connection
            conn.Open();

            //step 4 - create command object
            SqlCommand comm = new SqlCommand("sp_EmpHours_Insert", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            //add parameters
            comm.Parameters.Add(new SqlParameter("@empID", aEmpHour.EmpID));
            comm.Parameters.Add(new SqlParameter("@workDate", aEmpHour.WorkDate));
            comm.Parameters.Add(new SqlParameter("@hours", aEmpHour.Hours));

            //step 5 - run the command
            comm.ExecuteNonQuery();

            //step 6 - close connection
            conn.Close();
        }
        
    }
}
