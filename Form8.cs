using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyscord
{
    public partial class Form8 : Form
    {
        bool turn = true;
        int turnCount = 0;
        
        public Form8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Enabled = false;
                    turn = !turn;
                    b.Text = "X"; // turn = true, therefore x
                    turnCount++;
                    check();
                    displayTurn();
                }
            }
            catch { }
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            restart();
        }

        public void check()
        {
            bool winner = false;
            //horizontal
            if (buttonA1.Text == buttonA2.Text && buttonA2.Text == buttonA3.Text && buttonA1.Text != "")
            { winner = true; }
            else if (buttonB1.Text == buttonB2.Text && buttonB2.Text == buttonB3.Text && buttonB1.Text != "")
            { winner = true; }
            else if (buttonC1.Text == buttonC2.Text && buttonC2.Text == buttonC3.Text && buttonC1.Text != "")
            { winner = true; }

            // vertical
            if (buttonA1.Text == buttonB1.Text && buttonB1.Text == buttonC1.Text && buttonA1.Text != "")
            { winner = true; }
            else if (buttonA2.Text == buttonB2.Text && buttonB2.Text == buttonC2.Text && buttonA2.Text != "")
            { winner = true; }
            else if (buttonA3.Text == buttonB3.Text && buttonB3.Text == buttonC3.Text && buttonA3.Text != "")
            { winner = true; }

            // diagonal
            if (buttonA1.Text == buttonB2.Text && buttonB2.Text == buttonC3.Text && buttonA1.Text != "")
            { winner = true; }
            else if (buttonA3.Text == buttonB2.Text && buttonB2.Text == buttonC1.Text && buttonA3.Text != "")
            { winner = true; }

            if (winner)
            {
                string w = "";
                if (turn)
                {
                    w = "O";
                }
                else w = "X";
                MessageBox.Show("The winner is " + w + "! Click OK to restart the game");
                restart();
            }
            else if (turnCount == 0)
            {
                MessageBox.Show("It's a draw! Click OK to restart the game");
                restart();
            }
        }

        public void displayTurn()
        {
            if (turn)
            {
                turnTextBox.Text = "It is X's turn!";
            } else
            {
                turnTextBox.Text = "It is O's turn!";
            }
        }

        private void restart()
        {
            foreach(Control b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.Text = "";
            }

            turnCount = 0;
            turn = true;
            buttonReset.Text = "Reset";
        }
    }
}
