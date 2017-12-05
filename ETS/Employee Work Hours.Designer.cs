namespace ETS
{
    partial class EmployeeWorkHoursForm
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
            this.btnSearchWorkHour = new System.Windows.Forms.Button();
            this.lblEmp = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lstWorkDate = new System.Windows.Forms.ListBox();
            this.lstHours = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSearchWorkHour
            // 
            this.btnSearchWorkHour.Location = new System.Drawing.Point(103, 110);
            this.btnSearchWorkHour.Name = "btnSearchWorkHour";
            this.btnSearchWorkHour.Size = new System.Drawing.Size(83, 25);
            this.btnSearchWorkHour.TabIndex = 0;
            this.btnSearchWorkHour.Text = "Search Work Hours";
            this.btnSearchWorkHour.UseVisualStyleBackColor = true;
            this.btnSearchWorkHour.Click += new System.EventHandler(this.btnSearchWorkHour_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(122, 45);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(52, 12);
            this.lblEmp.TabIndex = 1;
            this.lblEmp.Text = "Employee";
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(77, 70);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(136, 20);
            this.cmbEmp.TabIndex = 3;
            this.cmbEmp.SelectedIndexChanged += new System.EventHandler(this.cmbEmp_SelectedIndexChanged);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(86, 162);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(39, 12);
            this.lblEmpID.TabIndex = 4;
            this.lblEmpID.Text = "EmpID";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(141, 162);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(54, 12);
            this.lblEmpName.TabIndex = 5;
            this.lblEmpName.Text = "EmpName";
            // 
            // lstWorkDate
            // 
            this.lstWorkDate.FormattingEnabled = true;
            this.lstWorkDate.ItemHeight = 12;
            this.lstWorkDate.Location = new System.Drawing.Point(55, 205);
            this.lstWorkDate.Name = "lstWorkDate";
            this.lstWorkDate.Size = new System.Drawing.Size(85, 160);
            this.lstWorkDate.TabIndex = 6;
            // 
            // lstHours
            // 
            this.lstHours.FormattingEnabled = true;
            this.lstHours.ItemHeight = 12;
            this.lstHours.Location = new System.Drawing.Point(146, 205);
            this.lstHours.Name = "lstHours";
            this.lstHours.Size = new System.Drawing.Size(94, 160);
            this.lstHours.TabIndex = 7;
            // 
            // EmployeeWorkHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 449);
            this.Controls.Add(this.lstHours);
            this.Controls.Add(this.lstWorkDate);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.btnSearchWorkHour);
            this.Name = "EmployeeWorkHoursForm";
            this.Text = "Employee Work Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchWorkHour;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.ListBox lstWorkDate;
        private System.Windows.Forms.ListBox lstHours;
    }
}