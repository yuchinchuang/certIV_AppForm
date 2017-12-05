using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ETS.Entity;
using ETS.Manager;

namespace ETS
{
    public partial class SearchWorkedHoursByEmpForm : Form
    {
        public SearchWorkedHoursByEmpForm()
        {
            InitializeComponent();
            EmployeeManager eM = new EmployeeManager();
            Result<List<Employee>> resultAllEmp = eM.GetAllEmp();

            switch (resultAllEmp.Status)
            {
                case ResultsEnum.SUCCESS:
                    lstEmp.DataSource = resultAllEmp.List;
                    lstEmp.DisplayMember = "FullName";
                    lstEmp.ValueMember = "EmpId";
                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get the Employee list");
                    break;
            }

        }

        private void lstEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)lstEmp.SelectedItem;

            lblEmpId.Text = "Employee ID: " + emp.EmpID;

            EmpHourManager ehM = new EmpHourManager();
            Result<List<EmpHour>> resultEH = ehM.GetEmpWorkByEmpId(emp.EmpID);

            double totalHour = 0;
            switch (resultEH.Status)
            {
                case ResultsEnum.SUCCESS:
                    lstWorkDate.DataSource = lstWorkHour.DataSource = resultEH.List;
                    lstWorkDate.DisplayMember = "WorkDate";
                    lstWorkDate.ValueMember = "EmpId";
                    lstWorkHour.DisplayMember = "Hour";
                    lstWorkHour.ValueMember = "Hour";

                    List<EmpHour>.Enumerator eList = resultEH.List.GetEnumerator();
                    while (eList.MoveNext())
                    {
                        EmpHour empH1 = eList.Current;
                        if (empH1.EmpID == emp.EmpID)
                        {
                            totalHour += empH1.Hour;
                        }
                    }

                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get the work list");
                    break;
            }

            lblTotalHours.Text = "Total working hours:\n" + totalHour;
        }
    }
}
