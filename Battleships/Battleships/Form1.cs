using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class Form1 : Form
    {

        public class Player
        {
            public Player(string playerName, Board board)
            {
                this.Name = playerName;
                this.Board = board;
            }

            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private Board board;
            public Board Board
            {
                get { return board; }
                set { board = value; }
            }
            private Ship[] ships;
            public Ship[] Ships
            {
                get { return ships; }
                set { ships = value; }
            }
            public bool ready = false;
            public int point = 0;
            public Button[] shots = new Button[36];
        }
        Thread Start;

        Player player1;
        Player player2;

        public bool ready = false;

        public Form1()
        {
            InitializeComponent();

            button1.Click += new EventHandler(Button1__Click);

        }

        private void Button1__Click(object sender, EventArgs e)
        {
            StartGame();
        }


        private void StartGame()
        {
            player1 = new Player("Player1", new Board("Player1"));
            player2 = new Player("Player2", new Board("Player2"));

            player1.Board.Show();
            player2.Board.Show();

            button1.Enabled = false;
            button1.Visible = false;
            label1.Visible = false;

            gameLogRichTextBox.Visible = true;

            Start = new Thread(() =>
            {
                do
                {
                    if (player1.ready == false) CheckBoards(player1);
                    if (player2.ready == false) CheckBoards(player2);

                } while (player1.ready == false || player2.ready == false);

                updateLog("Start Game");
                do
                {
                    startTurn(player1, player2);
                    startTurn(player2, player1);

                } while (player1.point < 17 || player2.point < 17);


            });
            Start.IsBackground = true;
            Start.Start();
        }

        private void CheckBoards(Player player)
        {
            if (player.Board.ready == true)
            {
                player.ready = true;
                
                updateLog(player.Name + " is ready");
                player.Ships = player.Board.ships;
                updateLog(player.Ships.ToString());
            }
        }

        private void startTurn(Player player, Player oppPlayer)
        {
            player.Board.StartTurn();
            CheckTurn(player, oppPlayer);
            player.Board.updateButton(false);
            player.Board.selectedShot = null;

            player.Board.updateLog(player.point.ToString());

            updateLog(player.Name + " turn ended");
            //do
            //{
            //} while (player.Board.turn == true);
        }

        private void CheckTurn(Player player, Player oppPlayer)
        {
            bool pass = false;
            do
            {
                if (player.Board.selectedShot != null)
                {
                    bool checkShot = true;

                    foreach (Button b in player.shots)
                    {
                        if (player.Board.selectedShot != b)
                        {
                            checkShot = false;
                            return;
                        }
                    }

                    player.Board.updateButton(checkShot);
                     
                    if (checkShot == true)
                    {
                        pass = true;


                        /*
                        foreach (Ship s in oppPlayer.Ships)
                        {
                            foreach (Button b in s.place)
                            {
                                if (player.Board.selectedShot == b)
                                {
                                    player.Board.updateLog("Hit " + s.ShipName);
                                    player.point++;
                                }
                            }
                        }*/
                        /*
                        for (int i = 0; i < player.shots.Length - 1; i++)
                        {
                            if (player.shots[i] == null)
                            {
                                player.shots[i] = player.Board.selectedShot;
                                player.Board.updateLog("Shots taken: " + (i + 1).ToString());
                                return;
                            }
                        }*/
                    }
                }

            } while (pass == false);
        }


        private void updateLog(string text)
        {
            if (gameLogRichTextBox.Text == "") gameLogRichTextBox.AppendText(text);
            else gameLogRichTextBox.AppendText("\n" + text);
        }
    }

    public class Ship
    {
        public bool ready = false;

        public Ship(string name, int size, Color color)
        {
            this.ShipName = name;
            this.Size = size;
            this.Color = color;
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
        private Color color;
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public Button[] place = null;
    }
}
