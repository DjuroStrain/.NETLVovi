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

namespace WindowsFormsCalculator
{
    /*
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double c;
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(inptFirstNumber.Value);
            double b = Convert.ToDouble(inptSecondNumber.Value);
            Calculator Calculator = new Calculator();
            double c = Calculator.Add(a, b);
            inptResult.Text = Convert.ToString(c);

        }
        

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(inptFirstNumber.Value);
            double b = Convert.ToDouble(inptSecondNumber.Value);
            Calculator Calculator = new Calculator();
            double c = Calculator.Substract(a, b);
            inptResult.Text = Convert.ToString(c);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(inptFirstNumber.Value);
            double b = Convert.ToDouble(inptSecondNumber.Value);
            Calculator Calculator = new Calculator();
            double c = Calculator.Multiply(a, b);
            inptResult.Text = Convert.ToString(c);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(inptFirstNumber.Value);
            double b = Convert.ToDouble(inptSecondNumber.Value);
            Calculator Calculator = new Calculator();
            double c = Calculator.Divide(a, b);
            inptResult.Text = Convert.ToString(c);
        }

        private void inptFirstNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inptSecondNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inptResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblFirstNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblSecondNumber_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
