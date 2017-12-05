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
    public partial class UpdateWorkForm : Form
    {
        public UpdateWorkForm()
        {
            InitializeComponent();
            EmpHourManager ehM = new EmpHourManager();
            Result<List<EmpHour>> resultEH = ehM.GetAllWorkEmp();

            switch (resultEH.Status)
            {
                case ResultsEnum.SUCCESS:
                    lstEmp.DataSource = resultEH.List;
                    lstEmp.DisplayMember = "FullName";
                    lstEmp.ValueMember = "EmpId";
                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get all work emp list");
                    break;
            }

            txtEmpId.Enabled = false;
        }

        private void lstEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpHour empH = (EmpHour)lstEmp.SelectedItem;

            txtEmpId.Text = empH.EmpID.ToString();

            EmpHourManager ehM = new EmpHourManager();
            Result<List<EmpHour>> resultEH = ehM.GetEmpWorkByEmpId(empH.EmpID);
            switch (resultEH.Status)
            {
                case ResultsEnum.SUCCESS:
                    cmbWorkDate.DataSource = resultEH.List;
                    cmbWorkDate.DisplayMember = "WorkDate";
                    cmbWorkDate.ValueMember = "EmpHourID";
                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get the work list");
                    break;
            }
        }

        private void cmbWorkDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpHour empH = (EmpHour) cmbWorkDate.SelectedItem;

            EmpHourManager ehM = new EmpHourManager();
            Result <List<EmpHour>> resultEH = ehM.GetEmpWorkByEmpHourId(empH.EmpHourID);

            switch (resultEH.Status)
            {
                case ResultsEnum.SUCCESS:
                    List<EmpHour>.Enumerator eList = resultEH.List.GetEnumerator();
                    while(eList.MoveNext())
                    {
                        EmpHour empH1 = eList.Current;
                        if (empH1.EmpHourID == empH.EmpHourID)
                        {
                            txtHours.Text = empH1.Hour.ToString();
                            break;
                        }
                    }
                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get the employee working hour list");
                    break;
            }

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            EmpHour empH = (EmpHour)cmbWorkDate.SelectedItem;

            try
            {
                EmpHour empH1 = (EmpHour)lstEmp.SelectedItem;
                empH1.WorkDate = empH.WorkDate;
                empH1.Hour = double.Parse(txtHours.Text);
                empH1.EmpHourID = empH.EmpHourID;

                Validation v = new Validation();
                v.ValidateDate(empH1.WorkDate);
                v.ValidateHour(empH1.Hour);

                EmpHourManager empHManager = new EmpHourManager();
                ResultsEnum result = empHManager.UpdateWorkHour(empH1);

                switch (result)
                {
                    case ResultsEnum.SUCCESS:
                        MessageBox.Show("Work Hour updated");
                        break;
                    case ResultsEnum.FAIL:
                        MessageBox.Show("Sorry...please try again later");
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
                MessageBox.Show("Invalid date");
            }
            catch (NoWorkHourException)
            {
                MessageBox.Show("Work hour must greater than zero");
            }
            catch (MaxDailyWorkException)
            {
                MessageBox.Show("No more than 24 hours work in a day");
            }

        }
    }
}
