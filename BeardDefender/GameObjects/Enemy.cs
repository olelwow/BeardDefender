using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeardDefender.GameObjects
{
    public partial class Enemy : UserControl
    {
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private int speed = 5;
        private Player player;

        public Enemy(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.igelkott;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Enemy
            // 
            Controls.Add(pictureBox1);
            Name = "Enemy";
            Size = new Size(48, 48);
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void Update(object sender, EventArgs e)
        {

            if (pictureBox1 != null)
            {
                if (player.Left > Left)
                {
                    Left += speed;
                }
                else if (player.Left < Left)
                {
                    Left -= speed;
                }

                if (player.Top > Top)
                {
                    Top += speed;
                }
                else if (player.Top < Top)
                {
                    Top -= speed;
                }
            }

            
            if (pictureBox1 != null && pictureBox1.Bounds.IntersectsWith(player.Bounds))
            {


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
