using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using System.Data.SqlClient;

namespace ETS.DataAccess
{
    public class EmployeesDao
    {
        public void CreateEmp(Employees aEmployee)
        {
            //step 1: create connection the object
            SqlConnection conn = new SqlConnection();

            //step 2: assign the connection string
            conn.ConnectionString = "Data Source=PEA104-18;Initial Catalog=EmpDatabase;User ID=sa;Password=Petersham";

            //step 3: open the connection
            conn.Open();

            //step 4 - create command object
            SqlCommand comm = new SqlCommand("sp_Employees_Insert", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            //add parameters
            comm.Parameters.Add(new SqlParameter("@firstName", aEmployee.FirstName));
            comm.Parameters.Add(new SqlParameter("@lastName", aEmployee.LastName));
            comm.Parameters.Add(new SqlParameter("@email", aEmployee.Email));
            comm.Parameters.Add(new SqlParameter("@dob", aEmployee.DOB));
            comm.Parameters.Add(new SqlParameter("@phone", aEmployee.Phone));


            //step 5 - run the command
            comm.ExecuteNonQuery();

            //step 6 - close connection
            conn.Close();
        }

    }
}
