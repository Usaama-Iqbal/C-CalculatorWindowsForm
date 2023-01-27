using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youCalculator
{
    public partial class frmCal : Form
    {
        public double num1, num2, result;
        public string operation;
        public frmCal()
        {
           
            InitializeComponent();
        }
            
        

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = ".";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            operation = "%";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            string message= " ";
            num2 = Convert.ToDouble(txtDisplay.Text);


            switch (operation)
            {
                case "+":
                    result = num1 + num2;

                    message = Convert.ToString(num1) + " + " + Convert.ToString(num2);
                    break;
                case "-":
                    result = num1 - num2;

                    message = Convert.ToString(num1) + " - " + Convert.ToString(num2);
                    break;
                case "*":
                    result = num1 * num2;

                    message = Convert.ToString(num1) + " * " + Convert.ToString(num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                    
                       message= "Cannot divided to ZERO";
                    }
                    else
                    {
                        message = Convert.ToString(num1) + " / " + Convert.ToString(num2);
                        result = num1 / num2;
}
                    break;
                case "%":
                    if (num2 == 0)
                    {

                        message = "Cannot Modulus to ZERO";
                    }
                    else
                    {
                        message = Convert.ToString(num1) + " % " + Convert.ToString(num2);
                        result = num1 % num2;
                    }

                    break;

                default:
                    break;
            }

            if (num2 == 0 && operation == "/")
            {
                txtDisplay.Text =Convert.ToString( message);
            }
            else {



                txtDisplay.Text =message + " = " + result.ToString();


            }


            if (num2 == 0 && operation == "%")
            {
                txtDisplay.Text = Convert.ToString(message);
            }
            else
            {



                txtDisplay.Text = message + " = " + result.ToString();


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = " ";
        }

        
    }
}
