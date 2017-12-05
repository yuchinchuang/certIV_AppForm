using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeForm frm = new AddEmployeeForm();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddWorkingHoursForm frm = new AddWorkingHoursForm();
            frm.ShowDialog();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm frm = new UpdateEmployeeForm();
            frm.ShowDialog();
        }

        private void workingHoursOfTheEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWorkedHoursByEmpForm frm = new SearchWorkedHoursByEmpForm();
            frm.ShowDialog();
        }

        private void workingEmployeesOfTheDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWorkedEmpsByDateForm frm = new SearchWorkedEmpsByDateForm();
            frm.ShowDialog();
        }

        private void updateEmployeeWorkingHourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWorkForm frm = new UpdateWorkForm();
            frm.ShowDialog();
        }

        private void employeesWorkingHourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWorkedHoursByEmpForm frm = new SearchWorkedHoursByEmpForm();
            frm.ShowDialog();
        }

        private void hoursOnWorkDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWorkedEmpsByDateForm frm = new SearchWorkedEmpsByDateForm();
            frm.ShowDialog();
        }
    }
}
