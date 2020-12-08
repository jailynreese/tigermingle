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
            public Ship(string Name, int Size)
            {
                this.ShipName = Name;
                this.Size = Size;
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
                set { Size = value; }
            }
        }

        public Ship selectedShip = null;
        public Ship[] ships;
        
        public Form1()
        {
            InitializeComponent();

            CreateButtons();
            CreateShips();
            //selectingShip();
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
            /*
            ships[0] = new Ship(carrierButton.Text, 5);
            ships[1] = new Ship(battleShipButton.Text, 4);
            ships[2] = new Ship(destroyerButton.Text, 3);
            ships[3] = new Ship(submarineButton.Text, 3);
            ships[4] = new Ship(patrolBoatButton.Text, 2);*/
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

            int x = (butt.Location.X - 150) / 50;
            int y = (butt.Location.Y - 10) / 50;
            playerLogRichTextBox.Text += x.ToString() + ":" + y.ToString() + " | ";

            //playerLogRichTextBox.Text += "\nSelected: " + butt.Text;
            if (selectedShip == null)
            {
                butt.BackColor = System.Drawing.Color.LightBlue;
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        board[x + i, y].BackColor = System.Drawing.Color.LightBlue;

                    }
                    catch
                    {

                    }
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

            butt.BackColor = System.Drawing.Color.White;
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
            /*
            selectedShip = null;
            
            foreach (Ship i in ships)
            {
                if (shipButt.Text == i.ShipName)
                {
                    selectedShip = i;
                }
            }*/

            if (shipButt.Name == carrierButton.Name) carrierButton.Enabled = false;
            else carrierButton.Enabled = true;
            if (shipButt.Name == battleShipButton.Name) battleShipButton.Enabled = false;
            else battleShipButton.Enabled = true;
            if (shipButt.Name == destroyerButton.Name) destroyerButton.Enabled = false;
            else destroyerButton.Enabled = true;
            if (shipButt.Name == submarineButton.Name) submarineButton.Enabled = false;
            else submarineButton.Enabled = true;
            if (shipButt.Name == patrolBoatButton.Name) patrolBoatButton.Enabled = false;
            else patrolBoatButton.Enabled = true;

            playerLogRichTextBox.Text += "Selected: " +  shipButt.Text + "\n";
        }
    }
}
