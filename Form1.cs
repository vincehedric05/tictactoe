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
                Console.WriteLine(counter);
            }
            else
            {
                button1.Text = "O";
                counter = counter + 1;
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
    }
}
