using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using ETS.DataAccess;

namespace ETS.Manager
{
    public class EmpHourManager
    {
        private readonly EmpHourDao eHdao;

        public EmpHourManager()
        {
            eHdao = new EmpHourDao();
        }

        public ResultsEnum AddWork(EmpHour newEmpHour)
        {
            
            ResultsEnum result = ResultsEnum.SUCCESS;
            try
            {
                eHdao.CreateWork(newEmpHour);
            }
            catch (Exception ex)
            {
                result = ResultsEnum.FAIL;
                Console.WriteLine("Error, AddWork, " + ex.Message);
            }
            return result;
        }

        public Result<List<EmpHour>> GetEmpWorkByEmpId(int empId)
        {
            Result<List<EmpHour>> result = new Result<List<EmpHour>>();
            try
            {
                result.List = eHdao.SelectEmpWorkByEmpId(empId);
                result.Status = ResultsEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                result.Status = ResultsEnum.FAIL;
                Console.WriteLine("Error, GetEmpWorkByEmpId, " + ex.Message);
            }

            return result;
        }

        public Result<List<DateTime>> GetAllWorkDate()
        {
            Result<List<DateTime>> result = new Result<List<DateTime>>();
            try
            {
                result.List = eHdao.AllWorkDate();
                result.Status = ResultsEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                result.Status = ResultsEnum.FAIL;
                Console.WriteLine("Error, GetAllWorkDate, " + ex.Message);
            }
            return result;
        }

        public Result<List<EmpHour>> GetAllEmpByDate(DateTime workDate)
        {
            Result<List<EmpHour>> result = new Result<List<EmpHour>>();
            try
            {
                result.List = eHdao.SelectEmpHourByWorkDate(workDate);
                result.Status = ResultsEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                result.Status = ResultsEnum.FAIL;
                Console.WriteLine("Error, GetAllEmpByDate, " + ex.Message);
            }
            return result;
        }

        public Result<List<EmpHour>> GetEmpWorkByEmpHourId(int empHourId)
        {
            Result<List<EmpHour>> result = new Result<List<EmpHour>>();
            try
            {
                result.List = eHdao.SelectEmpWorkByEmpHourId(empHourId);
                result.Status = ResultsEnum.SUCCESS;
            }
            catch (Exception ex)
            {
                result.Status = ResultsEnum.FAIL;
                Console.WriteLine("Error, GetEmpWorkByEmpHourId, " + ex.Message);
            }

            return result;
        }

        public ResultsEnum UpdateWorkHour(EmpHour empH)
        {
            ResultsEnum result = ResultsEnum.SUCCESS;
            try
            {
                eHdao.UpdateEmpHour(empH);
            }
            catch (Exception ex)
            {
                result = ResultsEnum.FAIL;
                Console.WriteLine("Error, UpdateWorkHour, " + ex.Message);
            }
            return result;
        }

        public Result<List<EmpHour>> GetAllWorkEmp()
        {
            Result<List<EmpHour>> result = new Result<List<EmpHour>>();

            try
            {
                result.List = eHdao.SelectAllWorkEmp();
                result.Status = ResultsEnum.SUCCESS;
            }
            catch(Exception ex)
            {
                result.Status = ResultsEnum.FAIL;
                Console.WriteLine("Error, GetAllWorkEmp " + ex.Message);
            }
            return result;
        }
    }
}
