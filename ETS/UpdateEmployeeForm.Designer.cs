namespace ETS
{
    partial class UpdateEmployeeForm
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblListOfEmp = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUpdateDetails = new System.Windows.Forms.Label();
            this.lstEmp = new System.Windows.Forms.ListBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(217, 335);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(124, 43);
            this.btnSaveChanges.TabIndex = 44;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblListOfEmp
            // 
            this.lblListOfEmp.AutoSize = true;
            this.lblListOfEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfEmp.Location = new System.Drawing.Point(28, 35);
            this.lblListOfEmp.Name = "lblListOfEmp";
            this.lblListOfEmp.Size = new System.Drawing.Size(151, 20);
            this.lblListOfEmp.TabIndex = 43;
            this.lblListOfEmp.Text = "List of Employees";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(213, 66);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(67, 12);
            this.lblEmpID.TabIndex = 41;
            this.lblEmpID.Text = "Employee ID";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(216, 256);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(159, 22);
            this.dtpDOB.TabIndex = 40;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(216, 300);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(159, 22);
            this.txtPhone.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 22);
            this.txtEmail.TabIndex = 38;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(217, 163);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(158, 22);
            this.txtLName.TabIndex = 37;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(216, 116);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(159, 22);
            this.txtFName.TabIndex = 36;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(216, 285);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(34, 12);
            this.lblPhone.TabIndex = 35;
            this.lblPhone.Text = "Phone";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(214, 237);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(29, 12);
            this.lblDOB.TabIndex = 34;
            this.lblDOB.Text = "DOB";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(214, 192);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 12);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(213, 148);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 12);
            this.lblLastName.TabIndex = 32;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(214, 102);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 12);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "First Name";
            // 
            // lblUpdateDetails
            // 
            this.lblUpdateDetails.AutoSize = true;
            this.lblUpdateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDetails.Location = new System.Drawing.Point(212, 35);
            this.lblUpdateDetails.Name = "lblUpdateDetails";
            this.lblUpdateDetails.Size = new System.Drawing.Size(129, 20);
            this.lblUpdateDetails.TabIndex = 31;
            this.lblUpdateDetails.Text = "Update Details";
            // 
            // lstEmp
            // 
            this.lstEmp.FormattingEnabled = true;
            this.lstEmp.ItemHeight = 12;
            this.lstEmp.Location = new System.Drawing.Point(32, 76);
            this.lstEmp.Name = "lstEmp";
            this.lstEmp.Size = new System.Drawing.Size(145, 232);
            this.lstEmp.TabIndex = 42;
            this.lstEmp.SelectedIndexChanged += new System.EventHandler(this.lstEmp_SelectedIndexChanged);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(286, 63);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(89, 22);
            this.txtEmpId.TabIndex = 45;
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 390);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblListOfEmp);
            this.Controls.Add(this.lstEmp);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblUpdateDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateEmployeeForm";
            this.Text = "UpdateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblListOfEmp;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUpdateDetails;
        private System.Windows.Forms.ListBox lstEmp;
        private System.Windows.Forms.TextBox txtEmpId;
    }
}