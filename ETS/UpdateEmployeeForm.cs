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
    public partial class UpdateEmployeeForm : Form
    {
        public UpdateEmployeeForm()
        {
            InitializeComponent();
            EmployeeManager empManager = new EmployeeManager();
            Result<List<Employee>> empList = empManager.GetAllEmp();

            switch (empList.Status)
            {
                case ResultsEnum.SUCCESS:
                    lstEmp.DataSource = empList.List;
                    lstEmp.DisplayMember = "FullName";
                    lstEmp.ValueMember = "EmpId";
                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get the Employee list");
                    break;
            }

            txtEmpId.Enabled = false;
        }

        private void lstEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)lstEmp.SelectedItem;

            EmployeeManager eM = new EmployeeManager();
            Result<Employee> resultEmp = eM.GetSelectedEmp(emp.EmpID);

            switch (resultEmp.Status)
            {
                case ResultsEnum.SUCCESS:
                    txtEmpId.Text = emp.EmpID.ToString();
                    txtFName.Text = emp.FirstName;
                    txtLName.Text = emp.LastName;
                    txtEmail.Text = emp.Email;
                    dtpDOB.Text = emp.DOB.ToString();
                    txtPhone.Text = emp.Phone;
                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get detail of the employee");
                    break;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = (Employee)lstEmp.SelectedItem;
                emp.FirstName = txtFName.Text;
                emp.LastName = txtLName.Text;
                emp.Email = txtEmail.Text;
                emp.DOB = dtpDOB.Value;
                emp.Phone = txtPhone.Text;

                Validation v = new Validation();
                v.ValidateName(emp.FirstName);
                v.ValidateName(emp.LastName);
                v.ValidateEmail(emp.Email);
                v.ValidateDate(emp.DOB);
                v.ValidatePhone(emp.Phone);

                EmployeeManager empManager = new EmployeeManager();
                ResultsEnum result = empManager.UpdateDetails(emp);

                switch (result)
                {
                    case ResultsEnum.SUCCESS:
                        MessageBox.Show("Employee details updated");
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
            catch (TextMaxLengthException)
            {
                MessageBox.Show("Too many characters in input");
            }
            catch(InvalidPhoneNumberException)
            {
                MessageBox.Show("Invalid phone number");
            }
            catch(FutureException)
            {
                MessageBox.Show("Invalid DOB");
            }
            catch (InvalidEmaiException)
            {
                MessageBox.Show("Invalid email address");
            }

        }
    }
}
