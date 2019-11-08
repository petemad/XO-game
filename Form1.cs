using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int turn = 0;
        public Form1()
        {
            InitializeComponent();
            resetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "X" || button1.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button1.Text = "X";
                turn++;
            }
            else
            {
                button1.Text = "O";
                turn++;
            }
            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }

        }
        public void resetAll()
        {
            button1.ResetText(); button2.ResetText(); button3.ResetText();
            button4.ResetText(); button5.ResetText(); button6.ResetText();
            button7.ResetText(); button8.ResetText(); button9.ResetText();
            button1.BackColor = default(Color);
            button2.BackColor = default(Color);
            button3.BackColor = default(Color);
            button4.BackColor = default(Color);
            button5.BackColor = default(Color);
            button6.BackColor = default(Color);
            button7.BackColor = default(Color);
            button8.BackColor = default(Color);
            button9.BackColor = default(Color);

        }
        public bool isDraw()
        {
            String v1 = button1.Text;
            String v2 = button2.Text;
            String v3 = button3.Text;
            String v4 = button4.Text;
            String v5 = button5.Text;
            String v6 = button6.Text;
            String v7 = button7.Text;
            String v8 = button8.Text;
            String v9 = button9.Text;
            if (v1 == ""){return false;}
            else if (v2 == "") { return false; }
            else if (v3 == "") { return false; }
            else if (v4 == "") { return false; }
            else if (v5 == "") { return false; }
            else if (v6 == "") { return false; }
            else if (v7 == "") { return false; }
            else if (v8 == "") { return false; }
            else if (v9 == "") { return false; }
            else { return true; }
        }

        public String Win_lose()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "")
            {
                button1.BackColor = Color.ForestGreen;
                button2.BackColor = Color.ForestGreen;
                button3.BackColor = Color.ForestGreen;
                return button1.Text ;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
            {
                button1.BackColor = Color.ForestGreen;
                button4.BackColor = Color.ForestGreen;
                button7.BackColor = Color.ForestGreen;
                return button1.Text;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
            {
                button1.BackColor = Color.ForestGreen;
                button5.BackColor = Color.ForestGreen;
                button9.BackColor = Color.ForestGreen;
                return button1.Text;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "")
            {
                button2.BackColor = Color.ForestGreen;
                button5.BackColor = Color.ForestGreen;
                button8.BackColor = Color.ForestGreen;
                return button2.Text;
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != "")
            {
                button3.BackColor = Color.ForestGreen;
                button6.BackColor = Color.ForestGreen;
                button9.BackColor = Color.ForestGreen;
                return button3.Text;
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "")
            {
                button4.BackColor = Color.ForestGreen;
                button5.BackColor = Color.ForestGreen;
                button6.BackColor = Color.ForestGreen;
                return button4.Text;
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "")
            {
                button7.BackColor = Color.ForestGreen;
                button8.BackColor = Color.ForestGreen;
                button9.BackColor = Color.ForestGreen;
                return button7.Text;
            }
            else if (button7.Text == button5.Text && button7.Text == button3.Text && button7.Text != "")
            {
                button7.BackColor = Color.ForestGreen;
                button5.BackColor = Color.ForestGreen;
                button3.BackColor = Color.ForestGreen;
                return button7.Text;
            }
            else
            {
                return "no winner";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "X" || button2.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button2.Text = "X";
                turn++;
            }
            else
            {
                button2.Text = "O";
                turn++;
            }
   
            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button3.Text = "X";
                turn++;
            }
            else
            {
                button3.Text = "O";
                turn++;
            }

            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "X" || button4.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button4.Text = "X";
                turn++;
            }
            else
            {
                button4.Text = "O";
                turn++;
            }
            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "X" || button5.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button5.Text = "X";
                turn++;
            }
            else
            {
                button5.Text = "O";
                turn++;
            }
            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "X" || button6.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button6.Text = "X";
                turn++;
            }
            else
            {
                button6.Text = "O";
                turn++;
            }

            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "X" || button7.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button7.Text = "X";
                turn++;
            }
            else
            {
                button7.Text = "O";
                turn++;
            }

            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "X" || button8.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button8.Text = "X";
                turn++;
            }
            else
            {
                button8.Text = "O";
                turn++;
            }

            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "X" || button9.Text == "O")
            {
                MessageBox.Show("Already clicked", "Error");
            }
            else if (turn % 2 == 0)
            {
                button9.Text = "X";
                turn++;
            }
            else
            {
                button9.Text = "O";
                turn++;
            }
   
            String check = Win_lose();
            if (check == "X")
            {
                MessageBox.Show("Player X won", "Game");
                resetAll();
            }
            else if (check == "O")
            {
                MessageBox.Show("player O won", "Game");
                resetAll();
            }
            else if (isDraw())
            {
                MessageBox.Show("It is a draw. ", "Game");
                resetAll();
            }
        }
    }
}
