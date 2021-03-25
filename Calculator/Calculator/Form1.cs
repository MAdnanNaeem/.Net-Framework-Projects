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
        double Value;
        string Operator;
        bool Check;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Pressed_Button(object sender, EventArgs e)
        {
            if( (Operator == "+") || (Operator == "-") || (Operator == "*") || (Operator == "/") )
            {
                if(Check)
                {
                    Check = false;
                    display.Text = "0";
                }

            }

            Button b = sender as Button;
            
            if(display.Text=="0")
            {
                display.Text = b.Text;

            }
            else
            {
                display.Text += b.Text;
            }
        }


        private void Operation(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Value = double.Parse(display.Text);
            Operator = b.Text;
            display.Text += b.Text ;
            Check = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            Value = 0;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Operator)
                {
                    case "+":
                        display.Text = (Value + double.Parse(display.Text)).ToString();
                        break;

                    case "-":
                        display.Text = (Value - double.Parse(display.Text)).ToString();
                        break;

                    case "*":
                        display.Text = (Value * double.Parse(display.Text)).ToString();
                        break;

                    case "/":
                        display.Text = (Value / double.Parse(display.Text)).ToString();
                        break;
                }
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
