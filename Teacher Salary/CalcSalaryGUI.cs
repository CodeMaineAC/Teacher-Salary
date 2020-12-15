using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Teacher Salary
 * 12/15/2020
 * Curvension of exercise 3.7 from python
 * Gives increase in salary year by year
 */
namespace Teacher_Salary
{
    public partial class CalcSalaryGUI : Form
    {
        public CalcSalaryGUI()
        {
            InitializeComponent();
        }
        
        private void salaryButton_Click(object sender, EventArgs e)
        {
            double startingSalary = Convert.ToDouble(startSalaryBox.Text);
            double rate = Convert.ToDouble(rateBox.Text);
            double years = Convert.ToDouble(yearsWorkedBox.Text);

            double currentSalary = startingSalary;
            rate = rate / 100.0;

            SalaryOutput.Text = "Year   |   Salary";

            for(int i = 1; i <= years; i++)
            {
                SalaryOutput.Text += string.Format("\n{0}   |   ${1:F2}"
                    , i, currentSalary);

                currentSalary += currentSalary * rate;
               
            }
            SalaryOutput.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            startSalaryBox.Visible = false;
            rateBox.Visible = false;
            yearsWorkedBox.Visible = false;
            NewCalculateButton.Visible = true;

        }

        //Makes textboxes and labels visible again 
        private void NewCalculateButton_Click(object sender, EventArgs e)
        {
            SalaryOutput.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            startSalaryBox.Visible = true;
            rateBox.Visible = true;
            yearsWorkedBox.Visible = true;
            NewCalculateButton.Visible = false;

        }
    }
}
