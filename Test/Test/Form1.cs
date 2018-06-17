using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Double val=0;
        String opreation = "";
        bool isopreation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isopreation))
            {
                textBox1.Clear();
            }
            Button button =(Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            isopreation = false;
        }

        private void Optrator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            opreation = button.Text;
            val = Double.Parse(textBox1.Text);
            label3.Text = val + " " + opreation;
            isopreation = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            val = 0;
        }

       

        private void button16_Click(object sender, EventArgs e)
        {
            switch(opreation)
            {
                case "+":
                    textBox1.Text = (val + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (val - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (val * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (val / Double.Parse(textBox1.Text)).ToString();
                    break;

                default :
                    break;


            }

        }

        
    }
}
