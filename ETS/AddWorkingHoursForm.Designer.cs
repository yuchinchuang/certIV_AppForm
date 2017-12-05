namespace ETS
{
    partial class AddWorkingHoursForm
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
            this.btnRecordHours = new System.Windows.Forms.Button();
            this.lblAddWorkingHours = new System.Windows.Forms.Label();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWorkDate = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRecordHours
            // 
            this.btnRecordHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordHours.Location = new System.Drawing.Point(32, 278);
            this.btnRecordHours.Name = "btnRecordHours";
            this.btnRecordHours.Size = new System.Drawing.Size(109, 27);
            this.btnRecordHours.TabIndex = 36;
            this.btnRecordHours.Text = "Record Hours";
            this.btnRecordHours.UseVisualStyleBackColor = true;
            this.btnRecordHours.Click += new System.EventHandler(this.btnRecordHours_Click);
            // 
            // lblAddWorkingHours
            // 
            this.lblAddWorkingHours.AutoSize = true;
            this.lblAddWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWorkingHours.Location = new System.Drawing.Point(28, 30);
            this.lblAddWorkingHours.Name = "lblAddWorkingHours";
            this.lblAddWorkingHours.Size = new System.Drawing.Size(164, 20);
            this.lblAddWorkingHours.TabIndex = 35;
            this.lblAddWorkingHours.Text = "Add Working Hours";
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkDate.Location = new System.Drawing.Point(32, 202);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(149, 22);
            this.dtpWorkDate.TabIndex = 34;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(32, 249);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(149, 22);
            this.txtHours.TabIndex = 33;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(29, 234);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(33, 12);
            this.lblHours.TabIndex = 32;
            this.lblHours.Text = "Hours";
            // 
            // lblWorkDate
            // 
            this.lblWorkDate.AutoSize = true;
            this.lblWorkDate.Location = new System.Drawing.Point(29, 188);
            this.lblWorkDate.Name = "lblWorkDate";
            this.lblWorkDate.Size = new System.Drawing.Size(56, 12);
            this.lblWorkDate.TabIndex = 31;
            this.lblWorkDate.Text = "Work Date";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(32, 66);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(52, 12);
            this.lblEmp.TabIndex = 37;
            this.lblEmp.Text = "Employee";
            // 
            // cmbEmp
            // 
            this.cmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(32, 94);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(150, 20);
            this.cmbEmp.TabIndex = 38;
            this.cmbEmp.SelectedIndexChanged += new System.EventHandler(this.cmbEmp_SelectedIndexChanged);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(30, 136);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(67, 12);
            this.lblEmpID.TabIndex = 40;
            this.lblEmpID.Text = "Employee ID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(31, 151);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 22);
            this.txtEmpID.TabIndex = 41;
            // 
            // AddWorkingHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 349);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.btnRecordHours);
            this.Controls.Add(this.lblAddWorkingHours);
            this.Controls.Add(this.dtpWorkDate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblWorkDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWorkingHoursForm";
            this.Text = "AddWorkingHours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordHours;
        private System.Windows.Forms.Label lblAddWorkingHours;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblWorkDate;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtEmpID;
    }
}