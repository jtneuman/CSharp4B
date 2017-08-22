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
        #region Constants
                const string noValue = "0";
                const string minusSign = "-";
                const string decimalSign = ".";
                const string plusSign = "+";
                const string divisionSign = "/";
                const string multiplicationSign = "x";
        #endregion
        #region Variables
        string memory = String.Empty;
        #endregion

        #region Methods

        private string AddDigit(string labelText, string buttonText)
        {
            if (labelText == noValue)
                labelText = String.Empty;

            labelText += buttonText;

            return labelText;
        }

        private void DeleteDigit(ref string newValue, string value)
        {
            int length = Convert.ToInt32(value.Length);

            if (length > 1)
                newValue = value.Substring(0, length - 1);

            if (newValue.Equals(minusSign))
                newValue = noValue;
        }

        private string AddDecimal(string value)
        {
            bool hasDecimal = value.Contains(decimalSign);
            if (!hasDecimal)
                value += decimalSign;

            return value;
        }

        private string ToggleSign(string value)
        {
            bool hasSign = value.Contains(minusSign);

            if (hasSign)
                value = value.Replace(minusSign, String.Empty);

            else if (value != noValue)
                value = value.Insert(0, minusSign);

            return value;
        }

        private bool CanCalculate()
        {
            return lblFirstValue.Text.Equals(String.Empty) ||
                   lblMathFunction.Text.Equals(String.Empty) ||
                   lblValue.Text.Equals(String.Empty) ||
                   lblValue.Text.Equals(noValue);              
        }

        private string EndWithDecimalSign(string value)
        {
            var endsWithDecimalSign = value.EndsWith(decimalSign);
            int length = Convert.ToInt32(value.Length);
            if (endsWithDecimalSign)
                value = value.Substring(0, length - 1);

            return value;
        }

        private void Calculate(out double result, double value1, double value2,
            string mathFunction)
        {
            result = 0d;

            if (mathFunction.Equals(plusSign))
                result = value1 + value2;
            else if (mathFunction.Equals(minusSign))
                result = value1 - value2;
            else if (mathFunction.Equals(divisionSign))
                result = value1 / value2;
            else if (mathFunction.Equals(multiplicationSign))
                result = value1 * value2;
        }
        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Events
                private void Form1_Load(object sender, EventArgs e)
                {

                }

                private void btnNumber_Click(object sender, EventArgs e)
                {
                    Button btn = (Button)sender;
                    lblValue.Text = AddDigit(lblValue.Text, btn.Text);
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                    string newValue = noValue;
                    DeleteDigit(ref newValue, lblValue.Text);
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
                    lblValue.Text = AddDecimal(lblValue.Text);
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
                    lblValue.Text = ToggleSign(lblValue.Text);
                }

                private void btnSqrt_Click(object sender, EventArgs e)
                {
                    bool hasSign = lblValue.Text.Contains(minusSign);

                    if (hasSign)
                    {
                        MessageBox.Show("Cannot calculate the square root of a negative number");
                        return; // Exit out of the event prematurely
                    }

                    lblValue.Text = EndWithDecimalSign(lblValue.Text);

                    int length = lblValue.Text.Length;
                    var value = Convert.ToDouble(lblValue.Text);
                    var result = Math.Sqrt(value);
                    lblValue.Text = result.ToString();
                }

                private void btnEquals_Click(object sender, EventArgs e)
                {
                    if (CanCalculate()) return;

                    lblFirstValue.Text = EndWithDecimalSign(lblFirstValue.Text);
                    lblValue.Text = EndWithDecimalSign(lblValue.Text);

                    var value1 = Convert.ToDouble(lblFirstValue.Text);
                    var value2 = Convert.ToDouble(lblValue.Text);
                    var mathFunction = lblMathFunction.Text;
                    var result = 0d; // double =0d

                    Calculate(out result, value1, value2, mathFunction);

                    lblMathFunction.Text = String.Empty;
                    lblFirstValue.Text = String.Empty;

                    lblValue.Text = result.ToString("F3");
                }

        #endregion

    }
}
