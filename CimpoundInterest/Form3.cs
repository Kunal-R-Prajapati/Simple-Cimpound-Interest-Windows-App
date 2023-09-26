using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CimpoundInterest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
            try
            {
                double principle = Convert.ToDouble(principleBox2.Text);
                double rate = (double)ratebox2.Value / 100;
                double time = Convert.ToDouble(timeBox2.Text);
                double n = (double)valueOfN.Value;
                double interest = (double)(principle * Math.Pow((1 + (rate / (100.0 * n))), n * time) - principle);
                Answer2.Text = "Total Interest is:\n" + Math.Round(interest,2).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Reset();
            }
        }

        private void ratebox1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resetBtn2_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void Reset()
        {
            principleBox2.Text = "";
            ratebox2.Value = 0;
            timeBox2.Text = "";
            valueOfN.Value = 0; 
            Answer2.Text = "";
        }
    }
}
