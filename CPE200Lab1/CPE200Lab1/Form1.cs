using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    
    public partial class Form1 : Form
    {
        bool DotExist;
        bool SignExist;
        string Value1;
        string Value2;
        string solution = "N";
        double x;
        double y;
        double z;
        int Operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void AppendNumber(string x)
        {
            
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + x;
        }
        
        private void MathOperation(int x)
        {
            Value1 = lblDisplay.Text;
            lblDisplay.Text = "";
            Operation = x;
        }
        


        private void btn9_Click(object sender, EventArgs e)
        {
            
            AppendNumber("9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
     
            AppendNumber("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            AppendNumber("7");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            if (DotExist == true)
            {
            }
            else
            {
                AppendNumber(".");
                DotExist = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   if (lblDisplay.Text.Length != 1)
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }else lblDisplay.Text = "0";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (SignExist == false)
            {
                lblDisplay.Text = "-" + lblDisplay.Text;
                SignExist = true;
            }
            else{
                 if(SignExist == true)
                {
                    lblDisplay.Text = lblDisplay.Text.Substring(lblDisplay.Text.Length-(lblDisplay.Text.Length-1));
                    SignExist = false;
                }
            }
       
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            MathOperation(1);         
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            MathOperation(2);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            MathOperation(3);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            MathOperation(4);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Value2 = lblDisplay.Text;
            x = Convert.ToDouble(Value1);
            y = Convert.ToDouble(Value2);
            if(Operation == 1)
            {
                z = x + y;
            }
            if (Operation == 2)
            {
                z = x - y;
            }
            if (Operation == 3)
            {
                z = x * y;
            }
            if (Operation == 4)
            {
                z = x / y;
            }
            solution = Convert.ToString(z);
            int i=solution.Length;
            if(i < 8)
            {
                lblDisplay.Text = solution;
            }
            else
            {

                lblDisplay.Text = "ERROR";
            }

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Value2 = lblDisplay.Text;
            x = Convert.ToDouble(Value1);
            y = Convert.ToDouble(Value2);
            y = (x / 100) * y;
            if(Operation == 1)
            {
                z = x + y;
            }
            if (Operation == 2)
            {
                z = x - y;
            }
            if (Operation == 3)
            {
                z = x * y;
            }
            if (Operation == 4)
            {
                z = x / y;
            }
            solution = Convert.ToString(z);
            if (solution.Length>8)
            {
                lblDisplay.Text = "ERROR";
            }
            else {
                
                lblDisplay.Text = solution;
                 }
            
          
            }

        }
    }

