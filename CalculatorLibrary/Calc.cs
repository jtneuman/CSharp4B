using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public static class Calc
    {
        #region Constants
        public const string noValue = "0";
        public const string minusSign = "-";
        public const string decimalSign = ".";
        public const string plusSign = "+";
        public const string divisionSign = "/";
        public const string multiplicationSign = "x";
        #endregion

        #region Methods
        public static string AddDigit(string labelText, string buttonText)
        {
            if (labelText == noValue)
                labelText = String.Empty;

            labelText += buttonText;

            return labelText;
        }

        public static void DeleteDigit(ref string newValue, string value)
        {
            int length = Convert.ToInt32(value.Length);

            if (length > 1)
                newValue = value.Substring(0, length - 1);

            if (newValue.Equals(minusSign))
                newValue = noValue;
        }

        public static string AddDecimal(string value)
        {
            bool hasDecimal = value.Contains(decimalSign);
            if (!hasDecimal)
                value += decimalSign;

            return value;
        }

        public static string ToggleSign(string value)
        {
            bool hasSign = value.Contains(minusSign);

            if (hasSign)
                value = value.Replace(minusSign, String.Empty);

            else if (value != noValue)
                value = value.Insert(0, minusSign);

            return value;
        }

        public static string EndsWithDecimalSign(string value)
        {
            var endsWithDecimalSign = value.EndsWith(decimalSign);
            int length = Convert.ToInt32(value.Length);
            if (endsWithDecimalSign)
                value = value.Substring(0, length - 1);

            return value;
        }

        public static void Calculate(out double result, double value1, double value2,
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
    }
}
