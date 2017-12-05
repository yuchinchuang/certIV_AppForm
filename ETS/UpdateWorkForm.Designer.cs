namespace ETS
{
    partial class UpdateWorkForm
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
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblListOfEmp = new System.Windows.Forms.Label();
            this.lstEmp = new System.Windows.Forms.ListBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblUpdateWorkDetails = new System.Windows.Forms.Label();
            this.cmbWorkDate = new System.Windows.Forms.ComboBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(284, 67);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(89, 22);
            this.txtEmpId.TabIndex = 55;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(216, 216);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(124, 43);
            this.btnSaveChanges.TabIndex = 54;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblListOfEmp
            // 
            this.lblListOfEmp.AutoSize = true;
            this.lblListOfEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfEmp.Location = new System.Drawing.Point(26, 39);
            this.lblListOfEmp.Name = "lblListOfEmp";
            this.lblListOfEmp.Size = new System.Drawing.Size(151, 20);
            this.lblListOfEmp.TabIndex = 53;
            this.lblListOfEmp.Text = "List of Employees";
            // 
            // lstEmp
            // 
            this.lstEmp.FormattingEnabled = true;
            this.lstEmp.ItemHeight = 12;
            this.lstEmp.Location = new System.Drawing.Point(30, 80);
            this.lstEmp.Name = "lstEmp";
            this.lstEmp.Size = new System.Drawing.Size(145, 232);
            this.lstEmp.TabIndex = 52;
            this.lstEmp.SelectedIndexChanged += new System.EventHandler(this.lstEmp_SelectedIndexChanged);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(211, 70);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(67, 12);
            this.lblEmpID.TabIndex = 51;
            this.lblEmpID.Text = "Employee ID";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(214, 171);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(159, 22);
            this.txtHours.TabIndex = 49;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(214, 156);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(33, 12);
            this.lblHours.TabIndex = 48;
            this.lblHours.Text = "Hours";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(212, 108);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(56, 12);
            this.lblDOB.TabIndex = 47;
            this.lblDOB.Text = "Work Date";
            // 
            // lblUpdateWorkDetails
            // 
            this.lblUpdateWorkDetails.AutoSize = true;
            this.lblUpdateWorkDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateWorkDetails.Location = new System.Drawing.Point(210, 39);
            this.lblUpdateWorkDetails.Name = "lblUpdateWorkDetails";
            this.lblUpdateWorkDetails.Size = new System.Drawing.Size(175, 20);
            this.lblUpdateWorkDetails.TabIndex = 46;
            this.lblUpdateWorkDetails.Text = "Update Work Details";
            // 
            // cmbWorkDate
            // 
            this.cmbWorkDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkDate.FormattingEnabled = true;
            this.cmbWorkDate.Location = new System.Drawing.Point(215, 124);
            this.cmbWorkDate.Name = "cmbWorkDate";
            this.cmbWorkDate.Size = new System.Drawing.Size(158, 20);
            this.cmbWorkDate.TabIndex = 56;
            this.cmbWorkDate.SelectedIndexChanged += new System.EventHandler(this.cmbWorkDate_SelectedIndexChanged);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIntroduction.Location = new System.Drawing.Point(30, 319);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(164, 24);
            this.lblIntroduction.TabIndex = 59;
            this.lblIntroduction.Text = "*Only employee who has worked \r\n  on this list";
            // 
            // UpdateWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 359);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.cmbWorkDate);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblListOfEmp);
            this.Controls.Add(this.lstEmp);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblUpdateWorkDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateWorkForm";
            this.Text = "UpdateWorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblListOfEmp;
        private System.Windows.Forms.ListBox lstEmp;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblUpdateWorkDetails;
        private System.Windows.Forms.ComboBox cmbWorkDate;
        private System.Windows.Forms.Label lblIntroduction;
    }
}