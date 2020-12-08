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
    public partial class Form1 : Form
    {
        public Button[,] board;
        public class Ship
        {
            public Ship(string name, int size)
            {
                this.ShipName = name;
                this.Size = size;
            }
            private string name;
            public string ShipName
            {
                get { return name; }
                set { name = value; }
            }
            private int size;
            public int Size
            {
                get { return size; }
                set { size = value; }
            }
        }

        public Ship selectedShip = null;
        public Ship[] ships;
        bool orientIsHorizontal = true;

        public Form1()
        {
            InitializeComponent();

            flipOrientButton.Click += new EventHandler(FlipOrientation);
            CreateButtons();
            CreateShips();
            selectingShip();
        }

        private void FlipOrientation(object sender, EventArgs e)
        {
            orientIsHorizontal = !orientIsHorizontal;
        }


        private void CreateButtons()
        {
            board = new Button[10, 10];

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    board[x, y] = new Button();
                    board[x, y].BackColor = System.Drawing.Color.White;
                    board[x, y].Location = new Point(150 + 50*x, 10 + 50*y);
                    board[x, y].Height = 50;
                    board[x, y].Width = 50;
                    board[x, y].Text = x.ToString() + ":" + y.ToString();
                    board[x, y].Name = x.ToString() + ":" + y.ToString() + "Button";

                    board[x, y].Click += new EventHandler(Tile__Click);
                    board[x, y].MouseEnter += new EventHandler(Tile__MouseEnter);
                    board[x, y].MouseLeave += new EventHandler(Tile__MouseLeave);

                    Controls.Add(board[x, y]);
                }
            }
        }

        private void CreateShips()
        {
            ships = new Ship[5];
            //playerLogRichTextBox.Text = ships.ToString();
            
            ships[0] = new Ship(this.carrierButton.Text, 5);
            ships[1] = new Ship(battleShipButton.Text, 4);
            ships[2] = new Ship(destroyerButton.Text, 3);
            ships[3] = new Ship(submarineButton.Text, 3);
            ships[4] = new Ship(patrolBoatButton.Text, 2);
        }

        private void Tile__Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;

            butt.BackColor = System.Drawing.Color.Blue;
            butt.ForeColor = System.Drawing.Color.Green;
        }

        private void Tile__MouseEnter(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (selectedShip != null)
            {
                Button[] place = placingShip(butt);
                foreach (Button i in place)
                {
                    i.BackColor = Color.LightBlue;
                }
            }
            else
            {
                butt.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void Tile__MouseLeave(object sender, EventArgs e)
        {
            Button butt = (Button)sender;

            if (selectedShip != null)
            {
                Button[] place = placingShip(butt);
                foreach (Button i in place)
                {
                    i.BackColor = Color.White;
                }
            }
            else
            {
                butt.BackColor = System.Drawing.Color.White;
            }
        }

        private Button[] placingShip(Button butt)
        {
            int size = selectedShip.Size;
            Button[] place = new Button[size];

            int x = (butt.Location.X - 150) / 50;
            int y = (butt.Location.Y - 10) / 50;
            playerLogRichTextBox.Text += x.ToString() + ":" + y.ToString() + " | ";

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

            playerLogRichTextBox.Text += "Selected: " +  selectedShip.ShipName + "\n";
        }
    }
}
