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
    public partial class TicTacToe : Form
    {
        public TicTacToe()
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
                Winner();
            }
            else
            {
                button1.Text = "O";
                counter = counter + 1;
                button1.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button2.Text = "O";
                counter = counter + 1;
                button2.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button3.Text = "O";
                counter = counter + 1;
                button3.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button4.Text = "O";
                counter = counter + 1;
                button4.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button5.Text = "O";
                counter = counter + 1;
                button5.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button6.Text = "O";
                counter = counter + 1;
                button6.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button7.Text = "O";
                counter = counter + 1;
                button7.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button8.Text = "O";
                counter = counter + 1;
                button8.Enabled = false;
                Winner();
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
                Winner();
            }
            else
            {
                button9.Text = "O";
                counter = counter + 1;
                button9.Enabled = false;
                Winner();
            }
        }

        private void reset_button(object sender, EventArgs e)
        {
            counter = 1;

            button1.Text = " ";
            button1.Enabled = true;

            button2.Text = " ";
            button2.Enabled = true;

            button3.Text = " ";
            button3.Enabled = true;

            button4.Text = " ";
            button4.Enabled = true;

            button5.Text = " ";
            button5.Enabled = true;

            button6.Text = " ";
            button6.Enabled = true;

            button7.Text = " ";
            button7.Enabled = true;

            button8.Text = " ";
            button8.Enabled = true;

            button9.Text = " ";
            button9.Enabled = true;

            winner_label.Text = "Tic Tac Toe";
        }
        public void Winner()
        {
            // 123
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 456
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 789
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 147
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 258
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 369
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 159
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 357
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 123
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "0")
            {
                winner_label.Text = "O Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 456
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                winner_label.Text = "0 Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 789
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                winner_label.Text = "O Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 147
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                winner_label.Text = "X Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 258
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                winner_label.Text = "O Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 369
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                winner_label.Text = "O Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 159
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                winner_label.Text = "O Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            // 357
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                winner_label.Text = "O Wins";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }
    }
}
