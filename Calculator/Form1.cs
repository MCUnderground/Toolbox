using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isPerformed=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if ((numberHolder.Text == "0") || (isPerformed))
                numberHolder.Clear();
            isPerformed = false;
            Button button = (Button)sender;
            numberHolder.Text = numberHolder.Text + button.Text;

        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                CheckOperation();
                resultValue = Double.Parse(numberHolder.Text);
                operationPerformed = button.Text;
                txtStored.Text = resultValue + " " + operationPerformed;
                isPerformed = true;
                
            }
            else { 
                operationPerformed = button.Text;
                resultValue = Double.Parse(numberHolder.Text);
                txtStored.Text = resultValue + " " + operationPerformed;
                isPerformed = true;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(numberHolder.Text))
            {
                numberHolder.Text = "0.";
            }
            if (!numberHolder.Text.Contains("."))
            {
                numberHolder.Text = numberHolder.Text + ".";
            }
        }

        private void numberHolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((String.IsNullOrEmpty(numberHolder.Text)) && (e.KeyChar == '.'))
            {
                numberHolder.Text = "0.";
            }

            if ((e.KeyChar == '.') && (numberHolder.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            numberHolder.Text = "0";
            resultValue = 0;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            CheckOperation();
            resultValue = 0;
            txtStored.Text = "";
        }

        private bool mouseDown;
        private Point lastLocation;

        private void CheckOperation()
        {
            switch (operationPerformed)
            {
                case "+":
                    numberHolder.Text = (resultValue + Double.Parse(numberHolder.Text)).ToString();
                    break;
                case "-":
                    numberHolder.Text = (resultValue - Double.Parse(numberHolder.Text)).ToString();
                    break;
                case "*":
                    numberHolder.Text = (resultValue * Double.Parse(numberHolder.Text)).ToString();
                    break;
                case "/":
                    numberHolder.Text = (resultValue / Double.Parse(numberHolder.Text)).ToString();
                    break;
                default:
                    break;

            }

        }

        private void toolBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void toolBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void toolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
