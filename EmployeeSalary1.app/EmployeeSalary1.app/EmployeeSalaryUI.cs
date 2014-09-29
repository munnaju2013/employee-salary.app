using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary1.app
{
    public partial class EmployeeSalaryUI : Form
    {
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void showMeAllButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.name = employeeNameTextBox.Text;
            aSalary.basic = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.housePersent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            aSalary.GetTotalSalary();
            MessageBox.Show(aSalary.name + " your salary is " + aSalary.GetTotalSalary());

            employeeNameTextBox.Text =String.Empty;
            basicAmountTextBox.Text = String.Empty;
            houseRentTextBox.Text = String.Empty;
            medicalAllowanceTextBox.Text = String.Empty;




        }
    }
}
