using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeardDefender.GameObjects
{
    public class Ground : UserControl
    {
        public Ground() 
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ground_10tiles;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-27, -390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(891, 565);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Ground
            // 
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Name = "Ground";
            Size = new Size(866, 105);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
    }
}
