using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        const string noValue = "0";
        const string minusSign = "-";
        const string decimalSign = ".";
        const string plusSign = "+";
        const string divisionSign = "/";
        const string multiplicationSign = "x";

        string memory = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lblValue.Text == noValue)
                lblValue.Text = String.Empty;

            lblValue.Text += btn.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string newValue = noValue;

            int length = Convert.ToInt32(lblValue.Text.Length);

            if (length > 1)
                newValue = lblValue.Text.Substring(0, length - 1);

            if (newValue.Equals(minusSign))
                newValue = noValue;

            lblValue.Text = newValue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblValue.Text = noValue;
            lblFirstValue.Text = String.Empty;
            lblMathFunction.Text = String.Empty;
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            memory = lblValue.Text;
            lblValue.Text = noValue;
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            lblValue.Text = memory;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            bool hasDecimal = lblValue.Text.Contains(decimalSign);
            if (!hasDecimal)
                lblValue.Text += decimalSign;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            lblMathFunction.Text = btn.Text;

            lblFirstValue.Text = lblValue.Text;

            lblValue.Text = noValue;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            bool hasSign = lblValue.Text.Contains(minusSign);

            if (hasSign)
                lblValue.Text = lblValue.Text.Replace(minusSign, String.Empty);

            else if (lblValue.Text != noValue)
                lblValue.Text = lblValue.Text.Insert(0, minusSign);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            bool hasSign = lblValue.Text.Contains(minusSign);

            if (hasSign)
            {
                MessageBox.Show("Cannot calculate the square root of a negative number");
                return;
            }

            var endsWithDecimalSign = lblValue.Text.EndsWith(decimalSign);

            int length = lblValue.Text.Length;

            if (endsWithDecimalSign)
                lblValue.Text = lblValue.Text.Substring(0, length - 1);

            var value = Convert.ToDouble(lblValue.Text);

            var result = Math.Sqrt(value);

            lblValue.Text = result.ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (lblFirstValue.Text.Equals(String.Empty) ||
                lblMathFunction.Text.Equals(String.Empty) ||
                lblValue.Text.Equals(noValue))
                return;
            var endsWithDecimalSign = lblFirstValue.Text.EndsWith(decimalSign);
            int length = Convert.ToInt32(lblFirstValue.Text.Length);
            if (endsWithDecimalSign)
                lblFirstValue.Text = lblFirstValue.Text.Substring(0, length - 1);

            length = Convert.ToInt32(lblValue.Text.Length);
            endsWithDecimalSign = lblValue.Text.EndsWith(decimalSign);
            if (endsWithDecimalSign)
                lblValue.Text = lblValue.Text.Substring(0, length - 1);

            var value1 = Convert.ToDouble(lblFirstValue.Text);
            var value2 = Convert.ToDouble(lblValue.Text);

            var mathFunction = lblMathFunction.Text;

            var result = 0d;

            if (mathFunction.Equals(plusSign))
                result = value1 + value2;
            else if (mathFunction.Equals(minusSign))
                result = value1 - value2;
            else if (mathFunction.Equals(divisionSign))
                result = value1 / value2;
            else if (mathFunction.Equals(multiplicationSign))
                result = value1 * value2;

            lblMathFunction.Text = String.Empty;
            lblFirstValue.Text = String.Empty;

            lblValue.Text = result.ToString("F3");

        }
    }
}
