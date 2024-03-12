using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeardDefender.GameObjects
{
    public class Player : UserControl
    {


        private PictureBox pictureBox1;
        private int speed = 3;
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.lose_icon;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 33;
            timer.Tick += Update;
            // 
            // Player
            // 
            Controls.Add(pictureBox1);
            Name = "Player";
            Size = new Size(101, 54);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        public Player()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.IContainer components;

        private void Update(object sender, EventArgs e)
        {
            if (PlayerMovement.IsUp)
            {
                Top -= speed;
            }
            if (PlayerMovement.IsDown)
            {
                Top += speed;
            }
            if (PlayerMovement.IsLeft)
            {
                Left -= speed;
            }
            if (PlayerMovement.IsRight)
            {
                Left += speed;
            }
        }
    }
}
