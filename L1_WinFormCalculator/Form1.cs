using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_WinFormCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double leftOperand = Double.Parse(leftOperandText.Text);
            double rightOperand = Double.Parse(rightOperandText.Text);
            char myOperator = '+';
            myOperator = myOperatorCombobox.Text[0];
            double result = 0.0;
            switch (myOperator)
            {
                case '+': result = leftOperand + rightOperand; break;
                case '-': result = leftOperand - rightOperand; break;
                case '*': result = leftOperand * rightOperand; break;
                case '/': result = leftOperand / rightOperand; break;
                case '%': result = leftOperand % rightOperand; break;
            }
            resultText.Text = result.ToString();
        }
    }
}
