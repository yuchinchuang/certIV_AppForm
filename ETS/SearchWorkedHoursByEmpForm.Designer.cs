namespace ETS
{
    partial class SearchWorkedHoursByEmpForm
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
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblListOfEmp = new System.Windows.Forms.Label();
            this.lblDateList = new System.Windows.Forms.Label();
            this.lstEmp = new System.Windows.Forms.ListBox();
            this.lstWorkDate = new System.Windows.Forms.ListBox();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblHourList = new System.Windows.Forms.Label();
            this.lstWorkHour = new System.Windows.Forms.ListBox();
            this.grpWorkDetail = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpWorkHour = new System.Windows.Forms.Label();
            this.grpWorkDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmpId.ForeColor = System.Drawing.Color.Blue;
            this.lblEmpId.Location = new System.Drawing.Point(3, 3);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(73, 14);
            this.lblEmpId.TabIndex = 0;
            this.lblEmpId.Text = "EmployeeId";
            // 
            // lblListOfEmp
            // 
            this.lblListOfEmp.AutoSize = true;
            this.lblListOfEmp.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblListOfEmp.Location = new System.Drawing.Point(21, 114);
            this.lblListOfEmp.Name = "lblListOfEmp";
            this.lblListOfEmp.Size = new System.Drawing.Size(131, 16);
            this.lblListOfEmp.TabIndex = 2;
            this.lblListOfEmp.Text = "List of Employee";
            // 
            // lblDateList
            // 
            this.lblDateList.AutoSize = true;
            this.lblDateList.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDateList.Location = new System.Drawing.Point(6, 31);
            this.lblDateList.Name = "lblDateList";
            this.lblDateList.Size = new System.Drawing.Size(36, 14);
            this.lblDateList.TabIndex = 3;
            this.lblDateList.Text = "Date";
            // 
            // lstEmp
            // 
            this.lstEmp.FormattingEnabled = true;
            this.lstEmp.Location = new System.Drawing.Point(25, 158);
            this.lstEmp.Name = "lstEmp";
            this.lstEmp.Size = new System.Drawing.Size(145, 251);
            this.lstEmp.TabIndex = 4;
            this.lstEmp.SelectedIndexChanged += new System.EventHandler(this.lstEmp_SelectedIndexChanged);
            // 
            // lstWorkDate
            // 
            this.lstWorkDate.FormattingEnabled = true;
            this.lstWorkDate.Location = new System.Drawing.Point(6, 52);
            this.lstWorkDate.Name = "lstWorkDate";
            this.lstWorkDate.Size = new System.Drawing.Size(136, 199);
            this.lstWorkDate.TabIndex = 5;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(126, 4);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(68, 14);
            this.lblTotalHours.TabIndex = 6;
            this.lblTotalHours.Text = "TotalHours";
            // 
            // lblHourList
            // 
            this.lblHourList.AutoSize = true;
            this.lblHourList.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHourList.Location = new System.Drawing.Point(145, 31);
            this.lblHourList.Name = "lblHourList";
            this.lblHourList.Size = new System.Drawing.Size(38, 14);
            this.lblHourList.TabIndex = 7;
            this.lblHourList.Text = "Hour";
            // 
            // lstWorkHour
            // 
            this.lstWorkHour.FormattingEnabled = true;
            this.lstWorkHour.Location = new System.Drawing.Point(148, 52);
            this.lstWorkHour.Name = "lstWorkHour";
            this.lstWorkHour.Size = new System.Drawing.Size(103, 199);
            this.lstWorkHour.TabIndex = 8;
            // 
            // grpWorkDetail
            // 
            this.grpWorkDetail.Controls.Add(this.lstWorkDate);
            this.grpWorkDetail.Controls.Add(this.lblHourList);
            this.grpWorkDetail.Controls.Add(this.lstWorkHour);
            this.grpWorkDetail.Controls.Add(this.lblDateList);
            this.grpWorkDetail.Location = new System.Drawing.Point(181, 158);
            this.grpWorkDetail.Name = "grpWorkDetail";
            this.grpWorkDetail.Size = new System.Drawing.Size(257, 251);
            this.grpWorkDetail.TabIndex = 9;
            this.grpWorkDetail.TabStop = false;
            this.grpWorkDetail.Text = "Work Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEmpId);
            this.panel1.Controls.Add(this.lblTotalHours);
            this.panel1.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(181, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 34);
            this.panel1.TabIndex = 10;
            // 
            // lblEmpWorkHour
            // 
            this.lblEmpWorkHour.AutoSize = true;
            this.lblEmpWorkHour.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmpWorkHour.Location = new System.Drawing.Point(80, 43);
            this.lblEmpWorkHour.Name = "lblEmpWorkHour";
            this.lblEmpWorkHour.Size = new System.Drawing.Size(311, 27);
            this.lblEmpWorkHour.TabIndex = 11;
            this.lblEmpWorkHour.Text = "Employee\'s Working Hour";
            // 
            // SearchWorkedHoursByEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 422);
            this.Controls.Add(this.lblEmpWorkHour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpWorkDetail);
            this.Controls.Add(this.lstEmp);
            this.Controls.Add(this.lblListOfEmp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWorkedHoursByEmpForm";
            this.Text = "SearchEmpWorkForm";
            this.grpWorkDetail.ResumeLayout(false);
            this.grpWorkDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblListOfEmp;
        private System.Windows.Forms.Label lblDateList;
        private System.Windows.Forms.ListBox lstEmp;
        private System.Windows.Forms.ListBox lstWorkDate;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblHourList;
        private System.Windows.Forms.ListBox lstWorkHour;
        private System.Windows.Forms.GroupBox grpWorkDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpWorkHour;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}