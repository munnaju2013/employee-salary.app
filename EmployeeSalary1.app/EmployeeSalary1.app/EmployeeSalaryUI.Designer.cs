namespace EmployeeSalary1.app
{
    partial class EmployeeSalaryUI
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
            this.showMeAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.basicAmountTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.medicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showMeAllButton
            // 
            this.showMeAllButton.Location = new System.Drawing.Point(241, 310);
            this.showMeAllButton.Name = "showMeAllButton";
            this.showMeAllButton.Size = new System.Drawing.Size(130, 34);
            this.showMeAllButton.TabIndex = 0;
            this.showMeAllButton.Text = "Show Me All";
            this.showMeAllButton.UseVisualStyleBackColor = true;
            this.showMeAllButton.Click += new System.EventHandler(this.showMeAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Basic Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "House Rent :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medical Alowance";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(241, 33);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.employeeNameTextBox.TabIndex = 5;
            // 
            // basicAmountTextBox
            // 
            this.basicAmountTextBox.Location = new System.Drawing.Point(241, 101);
            this.basicAmountTextBox.Name = "basicAmountTextBox";
            this.basicAmountTextBox.Size = new System.Drawing.Size(172, 20);
            this.basicAmountTextBox.TabIndex = 6;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(241, 152);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(172, 20);
            this.houseRentTextBox.TabIndex = 7;
            // 
            // medicalAllowanceTextBox
            // 
            this.medicalAllowanceTextBox.Location = new System.Drawing.Point(241, 220);
            this.medicalAllowanceTextBox.Name = "medicalAllowanceTextBox";
            this.medicalAllowanceTextBox.Size = new System.Drawing.Size(172, 20);
            this.medicalAllowanceTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "% of basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "% of basic";
            // 
            // EmployeeSalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 376);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.medicalAllowanceTextBox);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.basicAmountTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showMeAllButton);
            this.Name = "EmployeeSalaryUI";
            this.Text = "EmployeeSalaryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showMeAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox basicAmountTextBox;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.TextBox medicalAllowanceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

