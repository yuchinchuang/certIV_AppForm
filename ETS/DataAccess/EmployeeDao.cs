using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using System.Data.SqlClient;

namespace ETS.DataAccess
{
    public class EmployeeDao
    {
        public void CreateEmp(Employee aEmployee)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmployee_Insert", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@firstName", aEmployee.FirstName));
                comm.Parameters.Add(new SqlParameter("@lastName", aEmployee.LastName));
                comm.Parameters.Add(new SqlParameter("@email", aEmployee.Email));
                comm.Parameters.Add(new SqlParameter("@dob", aEmployee.DOB));
                comm.Parameters.Add(new SqlParameter("@phone", aEmployee.Phone));

                comm.ExecuteNonQuery();
            }
        }

        public List<Employee> SelectAllEmp()
        {
            List<Employee> list = new List<Employee>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();

            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmployee_SelectAllEmp",conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    emp.FullName = Convert.ToString(reader["FullName"]);

                    list.Add(emp);
                }

                return list;
            }
        }

        public Employee SearchEmpDetail(int empId)
        {
            Employee emp = new Employee();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmployee_SelectEmpID", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empID", empId));
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                }
            }
            return emp;
        }

        public void UpdateEmp(Employee emp)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmployee_Update", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empID", emp.EmpID));
                comm.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                comm.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                comm.Parameters.Add(new SqlParameter("@email", emp.Email));
                comm.Parameters.Add(new SqlParameter("@dob", emp.DOB));
                comm.Parameters.Add(new SqlParameter("@phone", emp.Phone));

                comm.ExecuteNonQuery();
            }
        }

        public string SearchEmail(string email)
        {
            Employee emp = new Employee();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmployee_SelectEmail", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@email", email));
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                }
            }
            return emp.Email;
        }

        public string SearchPhone(string phone)
        {
            Employee emp = new Employee();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmployee_SelectPhone", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@phone", phone));
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                }
            }
            return emp.Phone;
        }
    }
}
