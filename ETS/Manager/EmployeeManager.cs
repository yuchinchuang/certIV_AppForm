using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using ETS.DataAccess;
using ETS.ExceptionFolder;
using System.Windows.Forms;

namespace ETS.Manager
{
    public class EmployeeManager
    {
        private readonly EmployeeDao dao;

        public EmployeeManager()
        {
            dao = new EmployeeDao();
        }

        public ResultsEnum AddEmp(Employee newEmp)
        {
            ResultsEnum result = ResultsEnum.SUCCESS;
            try
            {
                if (dao.SearchEmail(newEmp.Email) == newEmp.Email)
                    throw new EmailDuplicatedException();

                if (dao.SearchPhone(newEmp.Phone) == newEmp.Phone)
                        throw new PhoneDuplicatedException();

                dao.CreateEmp(newEmp);
            }
            catch (EmailDuplicatedException)
            {
                result = ResultsEnum.FAIL;
                MessageBox.Show("Email already existed in system");
            }
            catch(PhoneDuplicatedException)
            {
                result = ResultsEnum.FAIL;
                MessageBox.Show("Phone number already existed in system");
            }
            catch(Exception ex)
            {
                result = ResultsEnum.FAIL;
                Console.WriteLine("Error, AddEmp, " + ex.Message);
            }
            return result;
        }

        public Result<List<Employee>> GetAllEmp()
        {
            Result<List<Employee>> result = new Result<List<Employee>>();

            try
            {
                result.List = dao.SelectAllEmp();
                result.Status = ResultsEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                result.Status = ResultsEnum.FAIL;
                Console.WriteLine("Error, GetAllEmp, " + ex.Message);
            }
            return result;
        }

        public Result<Employee> GetSelectedEmp(int empId)
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                result.List = dao.SearchEmpDetail(empId);
                result.Status = ResultsEnum.SUCCESS;
            }
            catch(Exception ex)
            {
                result.Status = ResultsEnum.FAIL;
                Console.WriteLine("Error, GetSelectedEmp, " + ex.Message);
            }
            return result;
        }

        public ResultsEnum UpdateDetails(Employee emp)
        {
            ResultsEnum result = ResultsEnum.SUCCESS;
            try
            {
                dao.UpdateEmp(emp);
            }
            catch(Exception ex)
            {
                result = ResultsEnum.FAIL;
                Console.WriteLine("Error, UpdateDetails, " + ex.Message);
            }
            return result;
        }
    }
}
