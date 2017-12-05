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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
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
                ResultsEnum result = empManager.AddEmp(emp);

                switch(result)
                {
                    case ResultsEnum.SUCCESS:
                        MessageBox.Show("One employee added to the database:" +
                                        "\n\nFirst Name: " + emp.FirstName +
                                        "\nLast Name: " + emp.LastName +
                                        "\nEmail: " + emp.Email +
                                        "\nDOB: " + emp.DOB.ToShortDateString() +
                                        "\nPhone: " + emp.Phone);
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
            catch(WhiteSpaceException)
            {
                MessageBox.Show("Input cannot contain space");
            }
            catch (InvalidPhoneNumberException)
            {
                MessageBox.Show("Invalid phone number");
            }
            catch (TextMaxLengthException)
            {
                MessageBox.Show("Too many characters in input");
            }
            catch (FutureException)
            {
                MessageBox.Show("Invalid DOB");
            }
            catch(InvalidEmaiException)
            {
                MessageBox.Show("Invalid email address");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            dtpDOB.Text = "";
            txtPhone.Clear();
        }
    }
}
