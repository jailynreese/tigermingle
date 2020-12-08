using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form7 : Form
    {
        bool turn = true;
        int turnCount = 0;

        public Form7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;

                if (turn == true)
                { //true corresponds to X's turn
                    b.Text = "X";
                }
                else b.Text = "O";
                turn = !turn;
                turnCount++;
                b.Enabled = false; // disable the button so other players can't change it after it's been clicked
                check(); // check for a winner
                displayTurn();

            }
            catch { }
        }

        public void check()
        {
            bool winner = false;
            //horizontal
            if (ButtonA1.Text == ButtonA2.Text && ButtonA2.Text == ButtonA3.Text && ButtonA1.Text != "")
            { winner = true; }
            else if (ButtonB1.Text == ButtonB2.Text && ButtonB2.Text == ButtonB3.Text && ButtonB1.Text != "")
            { winner = true; }
            else if (ButtonC1.Text == ButtonC2.Text && ButtonC2.Text == ButtonC3.Text && ButtonC1.Text != "")
            { winner = true; }

            // vertical
            if (ButtonA1.Text == ButtonB1.Text && ButtonB1.Text == ButtonC1.Text && ButtonA1.Text != "")
            { winner = true; }
            else if (ButtonA2.Text == ButtonB2.Text && ButtonB2.Text == ButtonC2.Text && ButtonA2.Text != "")
            { winner = true; }
            else if (ButtonA3.Text == ButtonB3.Text && ButtonB3.Text == ButtonC3.Text && ButtonA3.Text != "")
            { winner = true; }

            // diagonal
            if (ButtonA1.Text == ButtonB2.Text && ButtonB2.Text == ButtonC3.Text && ButtonA1.Text != "")
            { winner = true; }
            else if (ButtonA3.Text == ButtonB2.Text && ButtonB2.Text == ButtonC1.Text && ButtonA3.Text != "")
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
            else if (turnCount == 9)
            {
                MessageBox.Show("It's a draw! Click OK to restart the game");
                restart();
            }
        }

        public void displayTurn()
        {
            if (turn)
            {
                TextBoxTurn.Text = "It is X's turn!";
            }
            else TextBoxTurn.Text = "It is O's turn!";
        }

        private void restart()
        {
            foreach (Control b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.Text = "";
            }

            turnCount = 0;
            turn = true;
            ButtonRestart.Text = "Restart";
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
