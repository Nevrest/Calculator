using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double Value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (operation_pressed))
                Result.Clear();

            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Clear_Everything(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            Value = Double.Parse(Result.Text);
            operation_pressed = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                        Result.Text = (Value + Double.Parse(Result.Text)).ToString();
                    break;

                case "-":
                    Result.Text = (Value - Double.Parse(Result.Text)).ToString();
                    break;

                case "×":
                    Result.Text = (Value * Double.Parse(Result.Text)).ToString();
                    break;

                case "÷":
                    Result.Text = (Value / Double.Parse(Result.Text)).ToString();
                    break;

                case "√":
                    Result.Text = Math.Sqrt(Value).ToString();
                    //Result.Text = (Value Math.Sqrt Double.Parse(Result.Text)).ToString();
                    break;

                default:
                    break;
            }//End switch

            operation_pressed = false;

        }

        private void backspace_Click(object sender, EventArgs e)
        {
           
        }
    }
}

// richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);