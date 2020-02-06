namespace _3343_PerkinsA_Lab01
{
    partial class EmployeeDetailsForm
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
            this.nameDetailLabel = new System.Windows.Forms.Label();
            this.idNumberDetailLabel = new System.Windows.Forms.Label();
            this.departmentDetailLabel = new System.Windows.Forms.Label();
            this.positionDetailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameDetailLabel
            // 
            this.nameDetailLabel.AutoSize = true;
            this.nameDetailLabel.Location = new System.Drawing.Point(12, 9);
            this.nameDetailLabel.Name = "nameDetailLabel";
            this.nameDetailLabel.Size = new System.Drawing.Size(38, 13);
            this.nameDetailLabel.TabIndex = 0;
            this.nameDetailLabel.Text = "Name:";
            // 
            // idNumberDetailLabel
            // 
            this.idNumberDetailLabel.AutoSize = true;
            this.idNumberDetailLabel.Location = new System.Drawing.Point(12, 52);
            this.idNumberDetailLabel.Name = "idNumberDetailLabel";
            this.idNumberDetailLabel.Size = new System.Drawing.Size(61, 13);
            this.idNumberDetailLabel.TabIndex = 1;
            this.idNumberDetailLabel.Text = "ID Number:";
            // 
            // departmentDetailLabel
            // 
            this.departmentDetailLabel.AutoSize = true;
            this.departmentDetailLabel.Location = new System.Drawing.Point(12, 99);
            this.departmentDetailLabel.Name = "departmentDetailLabel";
            this.departmentDetailLabel.Size = new System.Drawing.Size(65, 13);
            this.departmentDetailLabel.TabIndex = 2;
            this.departmentDetailLabel.Text = "Department:";
            // 
            // positionDetailLabel
            // 
            this.positionDetailLabel.AutoSize = true;
            this.positionDetailLabel.Location = new System.Drawing.Point(12, 140);
            this.positionDetailLabel.Name = "positionDetailLabel";
            this.positionDetailLabel.Size = new System.Drawing.Size(47, 13);
            this.positionDetailLabel.TabIndex = 3;
            this.positionDetailLabel.Text = "Position:";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(100, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(148, 23);
            this.nameLabel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(188, 175);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.clearDetailButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idLabel.Location = new System.Drawing.Point(100, 51);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(151, 23);
            this.idLabel.TabIndex = 9;
            // 
            // departmentLabel
            // 
            this.departmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.departmentLabel.Location = new System.Drawing.Point(100, 98);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(148, 23);
            this.departmentLabel.TabIndex = 10;
            // 
            // positionLabel
            // 
            this.positionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionLabel.Location = new System.Drawing.Point(100, 130);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(151, 23);
            this.positionLabel.TabIndex = 11;
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 210);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.positionDetailLabel);
            this.Controls.Add(this.departmentDetailLabel);
            this.Controls.Add(this.idNumberDetailLabel);
            this.Controls.Add(this.nameDetailLabel);
            this.Name = "EmployeeDetailsForm";
            this.Text = "Employee_DetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label idLabel;
        public System.Windows.Forms.Label departmentLabel;
        public System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label nameDetailLabel;
        private System.Windows.Forms.Label idNumberDetailLabel;
        private System.Windows.Forms.Label departmentDetailLabel;
        private System.Windows.Forms.Label positionDetailLabel;
    }
}