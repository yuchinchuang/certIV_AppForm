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
    public partial class SearchWorkedEmpsByDateForm : Form
    {
        public SearchWorkedEmpsByDateForm()
        {
            InitializeComponent();
            EmpHourManager ehM = new EmpHourManager();
            Result<List<DateTime>> resultAllDate = ehM.GetAllWorkDate();

            switch (resultAllDate.Status)
            {
                case ResultsEnum.SUCCESS:
                    lstWorkDate.DataSource = resultAllDate.List;
                    lstWorkDate.DisplayMember = "WorkDate";
                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get the workdate list");
                    break;
            }
        }

        private void lstWorkDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date = (DateTime)lstWorkDate.SelectedItem;
            EmpHourManager ehM = new EmpHourManager();
            Result<List<EmpHour>> resultEH = ehM.GetAllEmpByDate(date);

            double totalHour = 0;
            switch (resultEH.Status)
            {
                case ResultsEnum.SUCCESS:
                    lstEmpName.DataSource = lstEmpHour.DataSource = resultEH.List;
                    lstEmpName.DisplayMember = "FullName";
                    lstEmpHour.DisplayMember = "Hour";
                    lstEmpName.ValueMember = lstEmpHour.ValueMember = "EmpID";

                    List<EmpHour>.Enumerator eList = resultEH.List.GetEnumerator();
                    while (eList.MoveNext())
                    {
                        EmpHour empH1 = eList.Current;
                        if (empH1.WorkDate == date)
                        {
                            totalHour += empH1.Hour;
                        }
                    }

                    break;
                case ResultsEnum.FAIL:
                    MessageBox.Show("Fail to get the employee list");
                    break;
            }

            lblDate.Text = "Date: " + date.ToShortDateString();
            lblDailyTotalHour.Text = "Daily total hour:\n" + totalHour ;

        }
    }
}
