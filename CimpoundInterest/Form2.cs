using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CimpoundInterest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
            try 
            {
                double principle = Convert.ToDouble(principleBox1.Text);
                double rate = (double) ratebox1.Value / 100;
                double time = Convert.ToDouble(timeBox1.Text);
                double interest = (double)(principle * rate * time);
                Answer1.Text = "Total Interest is:\n" + interest.ToString();

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }   
        }
        private void Reset()
        {
            principleBox1.Text = "";
            ratebox1.Value = 0;
            timeBox1.Text = "";
            Answer1.Text = "";
        }
    }
}
