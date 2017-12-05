using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using System.Data.SqlClient;

namespace ETS.DataAccess
{
    public class EmpHourDao
    {
        public void CreateWork(EmpHour aEmpHour)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = DataHelper.GetConnecctionString();
            
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmpHour_Insert", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empID", aEmpHour.EmpID));
                comm.Parameters.Add(new SqlParameter("@workDate", aEmpHour.WorkDate));
                comm.Parameters.Add(new SqlParameter("@hours", aEmpHour.Hour));

                comm.ExecuteNonQuery();
            }
        }

        public List<EmpHour> SelectEmpWorkByEmpId( int empId)
        {
            List<EmpHour> workList = new List<EmpHour>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();

            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmpHour_SelectEmpID", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empID", empId));
                SqlDataReader reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    EmpHour empH = new EmpHour();
                    empH.EmpID = Convert.ToInt32(reader["EmpID"]);
                    empH.EmpHourID = Convert.ToInt32(reader["EmpHourID"]);
                    empH.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    empH.Hour = Convert.ToDouble(reader["Hour"]);
                    empH.FullName = Convert.ToString(reader["FullName"]);

                    workList.Add(empH);
                }

                return workList ;
            }
        }

        public List<DateTime> AllWorkDate()
        {
            List<DateTime> list = new List<DateTime>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();

            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmpHour_DisplayAllWorkDate", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    DateTime date = Convert.ToDateTime(reader["WorkDate"]);

                    list.Add(date);
                }

                return list;
            }
        }
        
        public List<EmpHour> SelectEmpHourByWorkDate(DateTime workDate)
        {
            List<EmpHour> empList = new List<EmpHour>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();

            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmpHour_SelectDate", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@workDate", workDate));

                SqlDataReader reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    EmpHour empH = new EmpHour();
                    empH.EmpID = Convert.ToInt32(reader["EmpID"]);
                    empH.EmpHourID = Convert.ToInt32(reader["EmpHourID"]);
                    empH.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    empH.Hour = Convert.ToDouble(reader["Hour"]);
                    empH.FullName = Convert.ToString(reader["FullName"]);

                    empList.Add(empH);
                }

                return empList;
            }
        }

        public List<EmpHour> SelectEmpWorkByEmpHourId(int empHourId)
        {
            List<EmpHour> workList = new List<EmpHour>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();

            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmpHour_SelectEmpHourID", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empHourID", empHourId));
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    EmpHour empH = new EmpHour();
                    empH.EmpID = Convert.ToInt32(reader["EmpID"]);
                    empH.EmpHourID = Convert.ToInt32(reader["EmpHourID"]);
                    empH.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    empH.Hour = Convert.ToDouble(reader["Hour"]);
                    empH.FullName = Convert.ToString(reader["FullName"]);

                    workList.Add(empH);
                }

                return workList;
            }
        }

        public void UpdateEmpHour(EmpHour empH)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();
            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmpHour_UpdateWorkHour", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@empHourId", empH.EmpHourID));
                comm.Parameters.Add(new SqlParameter("@workDate", empH.WorkDate));
                comm.Parameters.Add(new SqlParameter("@hour", empH.Hour));

                comm.ExecuteNonQuery();
            }
        }


        public List<EmpHour> SelectAllWorkEmp()
        {
            List<EmpHour> list = new List<EmpHour>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataHelper.GetConnecctionString();
            conn.Open();

            using (conn)
            {
                SqlCommand comm = new SqlCommand("sp_TblEmpHour_DisplayAllWorkEmpID", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    EmpHour empH = new EmpHour();
                    empH.EmpID = Convert.ToInt32(reader["EmpID"]);
                    empH.FullName = Convert.ToString(reader["FullName"]);

                    list.Add(empH);
                }
                return list;
            }
        }
    }
}
