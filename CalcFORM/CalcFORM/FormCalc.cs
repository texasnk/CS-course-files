using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CalcFORM
{
    public partial class FormCalc : Form
    {
        double res = 0;
        string ope = "";
        bool opePerfomed = false;


        public FormCalc()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtBoxRes.Text == "0") || (opePerfomed))
            {
                txtBoxRes.Clear();
                opePerfomed=false;
            }
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!(txtBoxRes.Text.Contains(",")))
                {
                    if (txtBoxRes.Text.Length < 1)
                    {
                        txtBoxRes.Text += "0" + button.Text;

                    }
                    else
                    {
                        txtBoxRes.Text += button.Text;
                    }

                }
            }
            else
            {
                txtBoxRes.Text += button.Text;

            }


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtBoxRes.Text != "0")
            {
                buttonRes.PerformClick();
                ope = button.Text;
                res = double.Parse(txtBoxRes.Text);
                labelCurrent.Text = res + " " + ope;
            }
            else
            {
                ope = button.Text;
                res = double.Parse(txtBoxRes.Text);
                txtBoxRes.Text = "0";
                labelCurrent.Text = res + " " + ope;
            }



        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text = "0";
            res = 0;
            opePerfomed = false;
            labelCurrent.Text = "";

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            switch (ope)
            {
                case "+":
                    txtBoxRes.Text = (res + double.Parse(txtBoxRes.Text)).ToString();
                    break;
                case "-":
                    txtBoxRes.Text = (res - double.Parse(txtBoxRes.Text)).ToString();
                    break;
                case "*":
                    txtBoxRes.Text = (res * double.Parse(txtBoxRes.Text)).ToString();
                    break;
                case "/":
                    if (txtBoxRes.Text == "0")
                    {
                        txtBoxRes.Text = "Não é possível dividir por 0";
                        break;
                    }
                    else
                    {
                        txtBoxRes.Text = (res / double.Parse(txtBoxRes.Text)).ToString();
                        break;
                    }

                default:
                    break;
            }
            opePerfomed = true;
            res = 0;
            ope = "";
            labelCurrent.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
