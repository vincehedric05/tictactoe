using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 1;

        public void Counter()
        {
            int counter = 1;
        }

        private void button1_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button1.Text = "X";
                counter = counter + 1;
                button1.Enabled = false;
            }
            else
            {
                button1.Text = "O";
                counter = counter + 1;
                button1.Enabled = false;
            }
        }

        private void button2_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button2.Text = "X";
                counter = counter + 1;
                button2.Enabled = false;
            }
            else
            {
                button2.Text = "O";
                counter = counter + 1;
                button2.Enabled = false;
            }
        }

        private void button3_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button3.Text = "X";
                counter = counter + 1;
                button3.Enabled = false;
            }
            else
            {
                button3.Text = "O";
                counter = counter + 1;
                button3.Enabled = false;
            }
        }

        private void button4_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button4.Text = "X";
                counter = counter + 1;
                button4.Enabled = false;
            }
            else
            {
                button4.Text = "O";
                counter = counter + 1;
                button4.Enabled = false;
            }
        }

        private void button5_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button5.Text = "X";
                counter = counter + 1;
                button5.Enabled = false;
            }
            else
            {
                button5.Text = "O";
                counter = counter + 1;
                button5.Enabled = false;
            }
        }

        private void button6_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button6.Text = "X";
                counter = counter + 1;
                button6.Enabled = false;
            }
            else
            {
                button6.Text = "O";
                counter = counter + 1;
                button6.Enabled = false;
            }
        }

        private void button7_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button7.Text = "X";
                counter = counter + 1;
                button7.Enabled = false;
            }
            else
            {
                button7.Text = "O";
                counter = counter + 1;
                button7.Enabled = false;
            }
        }

        private void button8_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button8.Text = "X";
                counter = counter + 1;
                button8.Enabled = false;
            }
            else
            {
                button8.Text = "O";
                counter = counter + 1;
                button8.Enabled = false;
            }
        }

        private void button9_click(object sender, EventArgs e)
        {
            int odd_even = counter % 2;

            if (odd_even == 0)
            {
                button9.Text = "X";
                counter = counter + 1;
                button9.Enabled = false;
            }
            else
            {
                button9.Text = "O";
                counter = counter + 1;
                button9.Enabled = false;
            }
        }
    }
}
