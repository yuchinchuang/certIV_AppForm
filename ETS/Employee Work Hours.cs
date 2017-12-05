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
    public partial class EmployeeWorkHoursForm : Form
    {
        public EmployeeWorkHoursForm()
        {
            InitializeComponent();
            EmployeeManager empManager = new EmployeeManager();
            List<Employee> empList = empManager.GetAllEmp();
            cmbEmp.DataSource = empList;
            cmbEmp.DisplayMember = "FirstName";
            cmbEmp.ValueMember = "EmpId";
        }

        private void btnSearchWorkHour_Click(object sender, EventArgs e)
        {
            EmpHour empH = new EmpHour();
            
            EmpHourManager eM = new EmpHourManager();
            List<EmpHour> workList = eM.GetEmpWork();
            
        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)cmbEmp.SelectedItem;
            lblEmpID.Text = "Employee ID: " + emp.EmpId.ToString();
            lblEmpName.Text = emp.FirstName.ToString() + " " + emp.LastName.ToString();
        }
    }
}
