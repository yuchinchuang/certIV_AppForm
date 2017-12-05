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
using ETS.ExceptionFolder;

namespace ETS
{
    public partial class AddWorkingHoursForm : Form
    {
        public AddWorkingHoursForm()
        {
            InitializeComponent();
            EmployeeManager empManager = new EmployeeManager();
            Result<List<Employee>> empList = empManager.GetAllEmp();
            cmbEmp.DataSource = empList.List;
            cmbEmp.DisplayMember = "FullName";
            cmbEmp.ValueMember = "EmpID";
        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)cmbEmp.SelectedItem;
            txtEmpID.Text = emp.EmpID.ToString();
        }

        private void btnRecordHours_Click(object sender, EventArgs e)
        {
            try
            {
                EmpHour empH = new EmpHour();
                empH.WorkDate = DateTime.Parse(dtpWorkDate.Text);
                empH.Hour = double.Parse(txtHours.Text);
                empH.EmpID = (int)cmbEmp.SelectedValue;

                Validation v = new Validation();
                v.ValidateDate(empH.WorkDate);
                v.ValidateHour(empH.Hour);

                EmpHourManager empHManager = new EmpHourManager();
                ResultsEnum result = empHManager.AddWork(empH);

                Employee emp = (Employee)cmbEmp.SelectedItem;
                string empFullName = emp.FirstName + " " + emp.LastName;

                switch (result)
                {
                    case ResultsEnum.SUCCESS:
                        MessageBox.Show("Employee ID " + emp.EmpID +
                                        "\n" + empFullName +
                                        "\nWork Date: " + empH.WorkDate.ToShortDateString() +
                                        "\nHour: " + decimal.Round((decimal)empH.Hour, 2) +
                                        "\n\nWork Added");
                        break;
                    case ResultsEnum.FAIL:
                        MessageBox.Show("Sorry... please try again later");
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input");
            }
            catch (EmptyInputException)
            {
                MessageBox.Show("Input cannot be empty");
            }
            catch (WhiteSpaceException)
            {
                MessageBox.Show("Input cannot contain space");
            }
            catch (FutureException)
            {
                MessageBox.Show("Invalid work date");
            }
            catch (NoWorkHourException)
            {
                MessageBox.Show("Work hour must greater than zero");
            }
            catch(MaxDailyWorkException)
            {
                MessageBox.Show("No more than 24 hours work in a day");
            }


        }

    }
}
