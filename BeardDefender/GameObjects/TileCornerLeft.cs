using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeardDefender.GameObjects
{
    internal class TileCornerLeft : UserControl
    {
        public TileCornerLeft()
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
            pictureBox1.BackgroundImage = Properties.Resources.Vänster_hörn1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(159, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 649);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TileCornerLeft
            // 
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Name = "TileCornerLeft";
            Size = new Size(1365, 584);
            Tag = "object";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
    }
}
