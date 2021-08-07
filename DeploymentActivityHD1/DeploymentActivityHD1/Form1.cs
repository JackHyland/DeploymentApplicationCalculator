using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;
using CalculatePrint;

namespace DeploymentActivityHD1
{
    public partial class Form1 : Form
    {
        double Result;
        Calculate _calculate = new Calculate();
        CalculationPrint _caluationPrint = new CalculationPrint();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            label4.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Result = _calculate.Add(textBox1.Text, textBox2.Text);
            textBox3.Text = Convert.ToString(Result);
            label4.Text = _caluationPrint.Add();
        }
        private void Subract_Click(object sender, EventArgs e)
        {
            Result = _calculate.Subtract(textBox1.Text, textBox2.Text);
            textBox3.Text = Convert.ToString(Result);
            label4.Text = _caluationPrint.Subtract();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Result = _calculate.Multiply(textBox1.Text, textBox2.Text);
            textBox3.Text = Convert.ToString(Result);
            label4.Text = _caluationPrint.Multiply();

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Result = _calculate.Divide(textBox1.Text, textBox2.Text);
            textBox3.Text = Convert.ToString(Result);
            label4.Text = _caluationPrint.Divide();
        }
    }
}
