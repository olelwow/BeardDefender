
using BeardDefender.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BeardDefender
{
    public partial class GameLevel : Form
    {
        private System.Timers.Timer gameTimer;
        private Player player;
        public GameLevel()
        {
            InitializeComponent();
            gameTimer = new System.Timers.Timer();
            gameTimer.Interval = 16; 
            gameTimer.Elapsed += GameTimer_Elapsed;
            gameTimer.AutoReset = true;
            gameTimer.Start();
            this.DoubleBuffered = true;
            player = player1;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            PlayerMovement.OnKeyDownMove(e, player);

        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            PlayerMovement.OnKeyUpMove(e);
        }

        private void GameLevel_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckForCollisions();
        }
        private void GameTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            this.Invoke((MethodInvoker)delegate
            {
                CheckForCollisions();
            });
        }
        private void CheckForCollisions()
        {
            //Rectangle playerBounds = player1.Bounds;
            //Rectangle addHpBounds = addHp1.Bounds;

            //if (playerBounds.IntersectsWith(addHpBounds))
            //{
            //    // player1.AddHp = 2;
            //    player1.speed = 20;
            //    Controls.Remove(addHp1);
            //}

            foreach (Control obstacle in this.Controls)
            {


                if ((string?)obstacle.Tag == "object" && player1.Bounds.IntersectsWith(obstacle.Bounds))
                {
                    if (PlayerMovement.IsRight)
                    {
                        PlayerMovement.IsRight = false;
                        player1.Location = new Point(player1.Location.X - 8, player1.Location.Y);
                    }
                    if (PlayerMovement.IsLeft)
                    {
                        PlayerMovement.IsLeft = false;
                        player1.Location = new Point(player1.Location.X + 8, player1.Location.Y);
                    }
                    if (PlayerMovement.IsUp)
                    {
                        PlayerMovement.IsUp = false;
                        player1.Location = new Point(player1.Location.X, player1.Location.Y - 0);
                    }
                    if (PlayerMovement.IsDown)
                    {
                        PlayerMovement.IsDown = false;
                        player1.Location = new Point(player1.Location.X, player1.Location.Y + 0);
                    }
                }
            }
        }

        private void GameLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Elapsed -= GameTimer_Elapsed;
                gameTimer.Dispose();
            }
        }
    }
}