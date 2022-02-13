using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string userInput = "";
        string first = "";
        string second = "";
        char function;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '1';
            CalculatorDisplay.Text = userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '2';
            CalculatorDisplay.Text = userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '3';
            CalculatorDisplay.Text = userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '4';
            CalculatorDisplay.Text = userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '5';
            CalculatorDisplay.Text = userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '6';
            CalculatorDisplay.Text = userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '7';
            CalculatorDisplay.Text = userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '8';
            CalculatorDisplay.Text = userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '9';
            CalculatorDisplay.Text = userInput;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += '0';
            CalculatorDisplay.Text = userInput;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            first = userInput;
            userInput = "";
            function = '+';
            CalculatorDisplay.Text = "0";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            first = userInput;
            userInput = "";
            function = '-';
            CalculatorDisplay.Text = "0";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            first = userInput;
            userInput = "";
            function = '*';
            CalculatorDisplay.Text = "0";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            first = userInput;
            userInput = "";
            function = '/';
            CalculatorDisplay.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "0";
            userInput = "";
            result = 0.0;
            first = "";
            second = "";

        }

        private void equals_Click(object sender, EventArgs e)
        {
            second = userInput;
            
            switch(function)
            {
                case '+':
                    result = (Convert.ToDouble(first) + Convert.ToDouble(second));
                    break;
                case '-':
                    result = (Convert.ToDouble(first) - Convert.ToDouble(second));
                    break;
                case '*':
                    result = (Convert.ToDouble(first) * Convert.ToDouble(second));
                    break;
                case '/':
                    result = (Convert.ToDouble(first) / Convert.ToDouble(second));
                    break;
            }

            CalculatorDisplay.Text = Convert.ToString(result);
            userInput = "";
            result = 0.0;
            first = "";
            second = "";
        }
    }
}
