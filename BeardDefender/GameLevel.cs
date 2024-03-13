
using BeardDefender.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeardDefender
{
    public partial class GameLevel : Form
    {
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
            // Kollar efter hinder
            foreach (Control obstacle in this.Controls)
            {
                // Ett hinder klassas som hinder ifall det har taggen "object"
                if ((string?)obstacle.Tag == "object")
                {
                    // Ifall man stöter på ett hinder, och spelarens location på x-axeln är mindre än hindrets x så stoppas movement.
                    if (player.Bounds.IntersectsWith(obstacle.Bounds) && player.Location.X < obstacle.Left)
                    {
                        PlayerMovement.IsRight = false;
                        player.Location = new Point(obstacle.Left - 25, player.Location.Y);
                        if (player.Location.X >= obstacle.Location.X && e.KeyCode == PlayerMovement.KeyRight)
                        {
                            player.Location = new Point(obstacle.Left - 25, player.Location.Y);
                        }
                        if (player.Location.X >= obstacle.Right && e.KeyCode == PlayerMovement.KeyRight)
                        {
                            player.Location = new Point(obstacle.Left - 25, player.Location.Y);
                        }
                        //player.Speed = 0;
                        break;
                    }
                    if (player.Bounds.IntersectsWith(obstacle.Bounds) && player.Location.X > obstacle.Location.X - 15)
                    {
                        PlayerMovement.IsLeft = false;
                        player.Location = new Point(obstacle.Right, player.Location.Y);
                        //player.Speed = 0;
                        break;
                    }

                    // Chat gpt förslag, thanks for nothing...

                    //if ((string?)obstacle.Tag == "object")
                    //{
                    //    if (player1.Bounds.IntersectsWith(obstacle.Bounds))
                    //    {
                    //        // If the player is moving right and their left edge is within obstacle's bounds,
                    //        // adjust player's position to the left edge of the obstacle
                    //        if (PlayerMovement.IsRight && player1.Left < obstacle.Left)
                    //        {
                    //            PlayerMovement.IsRight = false;
                    //            player1.Left = obstacle.Left - player1.Width;
                    //        }
                    //        // If the player is moving left and their right edge is within obstacle's bounds,
                    //        // adjust player's position to the right edge of the obstacle
                    //        else if (PlayerMovement.IsLeft && player1.Right > obstacle.Right)
                    //        {
                    //            PlayerMovement.IsLeft = false;
                    //            player1.Left = obstacle.Right;
                    //        }
                    //    }
                }
            }
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
            Rectangle playerBounds = player1.Bounds;
            Rectangle addHpBounds = addHp1.Bounds;

            if (playerBounds.IntersectsWith(addHpBounds))
            {
                // player1.AddHp = 2;
                player1.speed = 5;
                Controls.Remove(addHp1);
            }

            Rectangle tileBounds = tileCornerLeft1.Bounds;
            if (playerBounds.IntersectsWith(tileBounds))
            {
                if (PlayerMovement.IsRight)
                {
                    PlayerMovement.IsRight = false;
                    player1.Location = new Point(player1.Location.X - 15, player1.Location.Y);
                }
                if (PlayerMovement.IsLeft)
                {
                    PlayerMovement.IsLeft = false;
                    player1.Location = new Point(player1.Location.X + 15, player1.Location.Y);
                }
                if (PlayerMovement.IsUp)
                {
                    PlayerMovement.IsUp = false;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 15);
                }
                if (PlayerMovement.IsDown)
                {
                    PlayerMovement.IsDown = false;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 15);
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
