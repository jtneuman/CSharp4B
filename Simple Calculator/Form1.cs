using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
 
        #region Variables
        string memory = String.Empty;
        #endregion

        #region Methods



        private bool CanCalcuate()
        {
            return lblFirstValue.Text.Equals(String.Empty) ||
                   lblMathFunction.Text.Equals(String.Empty) ||
                   lblValue.Text.Equals(String.Empty) ||
                   lblValue.Text.Equals(Calc.noValue);              
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
                    lblValue.Text = Calc.AddDigit(lblValue.Text, btn.Text);
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                    string newValue = Calc.noValue;
                    Calc.DeleteDigit(ref newValue, lblValue.Text);
                    lblValue.Text = newValue;
                }

                private void btnClear_Click(object sender, EventArgs e)
                {
                    lblValue.Text = Calc.noValue;
                    lblFirstValue.Text = String.Empty;
                    lblMathFunction.Text = String.Empty;
                }

                private void btnMemory_Click(object sender, EventArgs e)
                {
                    memory = lblValue.Text;
                    lblValue.Text = Calc.noValue;
                }

                private void btnMemoryRecall_Click(object sender, EventArgs e)
                {
                    lblValue.Text = memory;
                }

                private void btnDecimal_Click(object sender, EventArgs e)
                {
                    lblValue.Text = Calc.AddDecimal(lblValue.Text);
                }

                private void btnCalculate_Click(object sender, EventArgs e)
                {
                    Button btn = (Button)sender;

                    lblMathFunction.Text = btn.Text;

                    lblFirstValue.Text = lblValue.Text;

                    lblValue.Text = Calc.noValue;
                }

                private void btnSign_Click(object sender, EventArgs e)
                {
                    lblValue.Text = Calc.ToggleSign(lblValue.Text);
                }

                private void btnSqrt_Click(object sender, EventArgs e)
                {
                    bool hasSign = lblValue.Text.Contains(Calc.minusSign);

                    if (hasSign)
                    {
                        MessageBox.Show("Cannot Calc.Calc.Calcuate the square root of a negative number");
                        return; // Exit out of the event prematurely
                    }

                    lblValue.Text = Calc.EndsWithDecimalSign(lblValue.Text);

                    int length = lblValue.Text.Length;
                    var value = Convert.ToDouble(lblValue.Text);
                    var result = Math.Sqrt(value);
                    lblValue.Text = result.ToString();
                }

                private void btnEquals_Click(object sender, EventArgs e)
                {
                    if (CanCalcuate()) return;

                    lblFirstValue.Text = Calc.EndsWithDecimalSign(lblFirstValue.Text);
                    lblValue.Text = Calc.EndsWithDecimalSign(lblValue.Text);

                    var value1 = Convert.ToDouble(lblFirstValue.Text);
                    var value2 = Convert.ToDouble(lblValue.Text);
                    var mathFunction = lblMathFunction.Text;
                    var result = 0d; // double =0d

                    Calc.Calculate(out result, value1, value2, mathFunction);

                    lblMathFunction.Text = String.Empty;
                    lblFirstValue.Text = String.Empty;

                    lblValue.Text = result.ToString("F3");
                }

        #endregion

    }
}
