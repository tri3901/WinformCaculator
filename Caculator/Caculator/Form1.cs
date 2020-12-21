using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float operand1 = float.Parse(txtOperand1.Text);
            float operand2 = float.Parse(txtOperand2.Text);
            float sum = operand1 + operand2;
            txtAnswer.Text = sum.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            float operand1 = float.Parse(txtOperand1.Text);
            float operand2 = float.Parse(txtOperand2.Text);
            float sum = operand1 - operand2;
            txtAnswer.Text = sum.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            float operand1 = float.Parse(txtOperand1.Text);
            float operand2 = float.Parse(txtOperand2.Text);
            float sum = operand1 * operand2;
            txtAnswer.Text = sum.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float operand1 = float.Parse(txtOperand1.Text);
            float operand2 = float.Parse(txtOperand2.Text);
            float sum = operand1 / operand2;
            txtAnswer.Text = sum.ToString();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
