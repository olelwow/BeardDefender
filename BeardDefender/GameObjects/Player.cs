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
        private int speed = 5;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            pictureBox1 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 115);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 33;
            timer.Tick += Update;
            // 
            // Player
            // 
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Name = "Player";
            Size = new Size(77, 115);
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
            var screenHeight = ClientSize.Height;
            var screenWidth = ClientSize.Width;
            //if (PlayerMovement.IsUp && Top > 950)
            //{
            //    Top -= speed;
            //}
            //if (PlayerMovement.IsDown && Top < 1000)
            //{
            //    Top += speed;
            //}
            if (PlayerMovement.IsLeft && Left > 20)
            {
                Left -= speed;
            }
            if (PlayerMovement.IsRight && Left < 1790)
            {
                Left += speed;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
