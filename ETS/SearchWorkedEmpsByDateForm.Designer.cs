namespace ETS
{
    partial class SearchWorkedEmpsByDateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateList = new System.Windows.Forms.Label();
            this.lstWorkDate = new System.Windows.Forms.ListBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lstEmpName = new System.Windows.Forms.ListBox();
            this.lblWorkHour = new System.Windows.Forms.Label();
            this.lblDailyTotalHour = new System.Windows.Forms.Label();
            this.lstEmpHour = new System.Windows.Forms.ListBox();
            this.grpWorkDetail = new System.Windows.Forms.GroupBox();
            this.lblHoursOnWorkDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpWorkDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateList
            // 
            this.lblDateList.AutoSize = true;
            this.lblDateList.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDateList.Location = new System.Drawing.Point(21, 105);
            this.lblDateList.Name = "lblDateList";
            this.lblDateList.Size = new System.Drawing.Size(73, 16);
            this.lblDateList.TabIndex = 1;
            this.lblDateList.Text = "Date List";
            // 
            // lstWorkDate
            // 
            this.lstWorkDate.FormattingEnabled = true;
            this.lstWorkDate.ItemHeight = 12;
            this.lstWorkDate.Location = new System.Drawing.Point(25, 146);
            this.lstWorkDate.Name = "lstWorkDate";
            this.lstWorkDate.Size = new System.Drawing.Size(145, 232);
            this.lstWorkDate.TabIndex = 2;
            this.lstWorkDate.SelectedIndexChanged += new System.EventHandler(this.lstWorkDate_SelectedIndexChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmployee.Location = new System.Drawing.Point(6, 29);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(70, 14);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // lstEmpName
            // 
            this.lstEmpName.FormattingEnabled = true;
            this.lstEmpName.ItemHeight = 12;
            this.lstEmpName.Location = new System.Drawing.Point(6, 48);
            this.lstEmpName.Name = "lstEmpName";
            this.lstEmpName.Size = new System.Drawing.Size(136, 184);
            this.lstEmpName.TabIndex = 4;
            // 
            // lblWorkHour
            // 
            this.lblWorkHour.AutoSize = true;
            this.lblWorkHour.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWorkHour.Location = new System.Drawing.Point(145, 29);
            this.lblWorkHour.Name = "lblWorkHour";
            this.lblWorkHour.Size = new System.Drawing.Size(98, 14);
            this.lblWorkHour.TabIndex = 5;
            this.lblWorkHour.Text = "Working Hour";
            // 
            // lblDailyTotalHour
            // 
            this.lblDailyTotalHour.AutoSize = true;
            this.lblDailyTotalHour.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDailyTotalHour.ForeColor = System.Drawing.Color.Blue;
            this.lblDailyTotalHour.Location = new System.Drawing.Point(145, 3);
            this.lblDailyTotalHour.Name = "lblDailyTotalHour";
            this.lblDailyTotalHour.Size = new System.Drawing.Size(93, 14);
            this.lblDailyTotalHour.TabIndex = 7;
            this.lblDailyTotalHour.Text = "DailyTotalHour";
            // 
            // lstEmpHour
            // 
            this.lstEmpHour.FormattingEnabled = true;
            this.lstEmpHour.ItemHeight = 12;
            this.lstEmpHour.Location = new System.Drawing.Point(148, 48);
            this.lstEmpHour.Name = "lstEmpHour";
            this.lstEmpHour.Size = new System.Drawing.Size(103, 184);
            this.lstEmpHour.TabIndex = 8;
            // 
            // grpWorkDetail
            // 
            this.grpWorkDetail.Controls.Add(this.lstEmpName);
            this.grpWorkDetail.Controls.Add(this.lstEmpHour);
            this.grpWorkDetail.Controls.Add(this.lblWorkHour);
            this.grpWorkDetail.Controls.Add(this.lblEmployee);
            this.grpWorkDetail.Location = new System.Drawing.Point(181, 146);
            this.grpWorkDetail.Name = "grpWorkDetail";
            this.grpWorkDetail.Size = new System.Drawing.Size(257, 232);
            this.grpWorkDetail.TabIndex = 10;
            this.grpWorkDetail.TabStop = false;
            this.grpWorkDetail.Text = "Work Details";
            // 
            // lblHoursOnWorkDate
            // 
            this.lblHoursOnWorkDate.AutoSize = true;
            this.lblHoursOnWorkDate.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHoursOnWorkDate.Location = new System.Drawing.Point(114, 38);
            this.lblHoursOnWorkDate.Name = "lblHoursOnWorkDate";
            this.lblHoursOnWorkDate.Size = new System.Drawing.Size(244, 27);
            this.lblHoursOnWorkDate.TabIndex = 12;
            this.lblHoursOnWorkDate.Text = "Hours on Work Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblDailyTotalHour);
            this.panel1.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(181, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 35);
            this.panel1.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(32, 14);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // SearchWorkedEmpsByDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHoursOnWorkDate);
            this.Controls.Add(this.grpWorkDetail);
            this.Controls.Add(this.lstWorkDate);
            this.Controls.Add(this.lblDateList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWorkedEmpsByDateForm";
            this.Text = "Search Worked Employees By Date";
            this.grpWorkDetail.ResumeLayout(false);
            this.grpWorkDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateList;
        private System.Windows.Forms.ListBox lstWorkDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ListBox lstEmpName;
        private System.Windows.Forms.Label lblWorkHour;
        private System.Windows.Forms.Label lblDailyTotalHour;
        private System.Windows.Forms.ListBox lstEmpHour;
        private System.Windows.Forms.GroupBox grpWorkDetail;
        private System.Windows.Forms.Label lblHoursOnWorkDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
    }
}