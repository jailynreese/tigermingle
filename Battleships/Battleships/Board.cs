using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class Board : Form
    {
        public int width = 6;
        public int height = 6;
        public bool ready = false;
        public bool turn = false;
        public Button[,] board;
        public Button selectedShot = null;

        public Ship selectedShip = null;
        public Ship[] ships;
        bool orientIsHorizontal = true;

        public Board(string name)
        {
            InitializeComponent();

            this.Text = name;

            flipOrientButton.Click += new EventHandler(FlipOrientation);
            BoardSetup(width, height);
            CheckColors();
            selectingShip();
            startButton.Click += new EventHandler(StartButton__Click);
        }

        private void FlipOrientation(object sender, EventArgs e)
        {
            orientIsHorizontal = !orientIsHorizontal;
            if (orientIsHorizontal == true) flipOrientButton.Text = "Rotated: Horizontal";
            else if (orientIsHorizontal == false) flipOrientButton.Text = "Rotated: Vertical";
        }


        private void BoardSetup(int width, int height)
        {
            board = new Button[width, height];

            char[] key = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    board[x, y] = new Button();
                    board[x, y].Parent = battlePanel;
                    board[x, y].BackColor = System.Drawing.Color.White;
                    board[x, y].Location = new Point(battlePanel.Location.X + ((battlePanel.Width/width)*x), battlePanel.Location.Y + ((battlePanel.Height/height)*y));
                    board[x, y].Height = battlePanel.Width/width;
                    board[x, y].Width = battlePanel.Height/height;
                    board[x, y].Text = key[x] + ":" + y.ToString();
                    board[x, y].Name = key[x] + ":" + y.ToString() + "Button";
                    board[x, y].Click += new EventHandler(Tile__Click);
                    board[x, y].MouseEnter += new EventHandler(Tile__MouseEnter);
                    board[x, y].MouseLeave += new EventHandler(Tile__MouseLeave);

                    Controls.Add(board[x, y]);
                }
            }
            ships = new Ship[5];
            //updateLog(ships.ToString());

            ships[0] = new Ship(this.carrierButton.Text, 5, Color.Red);
            ships[1] = new Ship(battleShipButton.Text, 4, Color.Green);
            ships[2] = new Ship(destroyerButton.Text, 3, Color.Purple);
            ships[3] = new Ship(submarineButton.Text, 3, Color.Orange);
            ships[4] = new Ship(patrolBoatButton.Text, 2, Color.OliveDrab);
        }

        private void Tile__Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;

            bool pass = true;
            Button[] place = placingShip(butt);
            
            foreach (Button i in place)
            {
                if (selectedShip != null)
                {
                    foreach (Ship s in ships)
                    {
                        if (s.place != null)
                        {
                            foreach (Button q in s.place)
                            {
                                if (i == q) pass = false;
                            }
                        }
                    }
                }
                i.BackColor = System.Drawing.Color.Blue;
            }

            if (pass == true && selectedShip != null)
            {
                selectedShip.place = place;
                updateLog("Placed: " + selectedShip.ShipName);
                displayBoard();
            }
            else if (pass == false && selectedShip != null)
            {
                updateLog("Couldn't place: " + selectedShip.ShipName);
            }

            if (this.turn == true)
            {
                selectedShot = place[0];
                updateLog("SelectedShot");
            }
        }

        public void StartTurn()
        {
            startButton.Text = "End Turn";
            this.updateButton(false);
            this.updateLog("Your Turn");
            this.turn = true;
        }

        public void updateButton(bool state)
        {
            startButton.Enabled = state;
        }

        private void Tile__MouseEnter(object sender, EventArgs e)
        {
            Button butt = (Button)sender;

            Button[] place = placingShip(butt);
            foreach (Button i in place)
            {
                i.BackColor = Color.LightBlue;
            }
        }

        private void Tile__MouseLeave(object sender, EventArgs e)
        {
            Button butt = (Button)sender;

            Button[] place = placingShip(butt);
            foreach (Button i in place)
            {
                i.BackColor = Color.White;
            }

            displayBoard();
        }

        private Button[] placingShip(Button butt)
        {

            int size = 1;
            if (selectedShip != null) size = selectedShip.Size;
            Button[] place = new Button[size];

            int x = (butt.Location.X - this.battlePanel.Location.X) / (this.battlePanel.Width/width);
            int y = (butt.Location.Y - this.battlePanel.Location.Y) / (this.battlePanel.Height/height);
            //updateLog(x.ToString() + ":" + y.ToString() + " | ");

            for (int i = 0; i < size; i++)
            {
                try
                {
                    if (orientIsHorizontal == true) place[i] = board[x + i, y];
                    else if (orientIsHorizontal == false) place[i] = board[x, y + i];
                }
                catch
                {
                    int newLength = 0;
                    if (i == size - 1) newLength = -1;
                    else newLength = i - size;

                    if (orientIsHorizontal == true) place[i] = board[x + newLength, y];
                    else if (orientIsHorizontal == false) place[i] = board[x, y + newLength];
                }
            }

            return place;
        }

        private void selectingShip()
        {
            carrierButton.Click += new EventHandler(ShipSelect);
            battleShipButton.Click += new EventHandler(ShipSelect);
            destroyerButton.Click += new EventHandler(ShipSelect);
            submarineButton.Click += new EventHandler(ShipSelect);
            patrolBoatButton.Click += new EventHandler(ShipSelect);
        }

        private void ShipSelect(object sender, EventArgs e)
        {
            Button shipButt = (Button)sender;
            
            selectedShip = null;
            
            foreach (Ship i in ships)
            {
                if (shipButt.Text == i.ShipName)
                {
                    selectedShip = i;
                }
            }

            if (selectedShip.ShipName == carrierButton.Text) carrierButton.Enabled = false;
            else carrierButton.Enabled = true;
            if (selectedShip.ShipName == battleShipButton.Text) battleShipButton.Enabled = false;
            else battleShipButton.Enabled = true;
            if (selectedShip.ShipName == destroyerButton.Text) destroyerButton.Enabled = false;
            else destroyerButton.Enabled = true;
            if (selectedShip.ShipName == submarineButton.Text) submarineButton.Enabled = false;
            else submarineButton.Enabled = true;
            if (selectedShip.ShipName == patrolBoatButton.Text) patrolBoatButton.Enabled = false;
            else patrolBoatButton.Enabled = true;

            updateLog("Selected: " +  selectedShip.ShipName);
        }

        private void displayBoard()
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    Button butt = board[x, y];

                    butt.BackColor = Color.White;
                    butt.ForeColor = Color.Black;

                    foreach (Ship s in ships)
                    {
                        if (s.place != null)
                        {
                            foreach (Button b in s.place)
                            {
                                if (butt == b) 
                                { 
                                    butt.BackColor = s.Color;
                                    butt.ForeColor = Color.White;
                                }
                            }
                        }
                    }
                }
            }

            checkShips();
        }

        private void checkShips()
        {
            int checkShips = 0;

            foreach (Ship s in ships)
            {
                if (s.place != null)
                {
                    checkShips++;
                }
            }
            if (checkShips == ships.Length && this.turn == false)
            {
                startButton.Enabled = true;
            }
        }

        private void CheckColors()
        {
            carrierLabel.Click += new EventHandler(SelectColors);
            battleLabel.Click += new EventHandler(SelectColors);
            destroyerLabel.Click += new EventHandler(SelectColors);
            submarineLabel.Click += new EventHandler(SelectColors);
            patrolBoatLabel.Click += new EventHandler(SelectColors);
        }

        private void SelectColors(object sender, EventArgs e)
        {
            Label lab = (Label)sender;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lab.BackColor = colorDialog.Color;
                switch (lab.Name)
                {
                    case "carrierLabel":
                        ships[0].Color = lab.BackColor;
                        break;
                    case "battleLabel":
                        ships[1].Color = lab.BackColor;
                        break;
                    case "destroyerLabel":
                        ships[2].Color = lab.BackColor;
                        break;
                    case "submarineLabel":
                        ships[3].Color = lab.BackColor;
                        break;
                    case "patrolBoatLabel":
                        ships[4].Color = lab.BackColor;
                        break;
                }

                displayBoard();
            }
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            if (ready == false)
            {
                StartGame();
                return;
            }
            else
            {
                if (selectedShot != null)
                {
                    updateLog("Pressed EndTurn");
                    this.turn = false;
                }
            }
        }

        private void StartGame()
        {
            carrierButton.Enabled = false;
            battleShipButton.Enabled = false;
            destroyerButton.Enabled = false;
            submarineButton.Enabled = false;
            patrolBoatButton.Enabled = false;

            carrierLabel.Enabled = false;
            battleLabel.Enabled = false;
            destroyerLabel.Enabled = false;
            submarineLabel.Enabled = false;
            patrolBoatLabel.Enabled = false;

            startButton.Enabled = false;
            flipOrientButton.Enabled = false;
            selectedShip = null;

            ready = true;
            updateLog("Awaiting other player");
        }

        public void updateLog(string text)
        {
            if (playerLogRichTextBox.Text == "") playerLogRichTextBox.AppendText(text);
            else playerLogRichTextBox.AppendText("\n" + text);
        }
    }

}
