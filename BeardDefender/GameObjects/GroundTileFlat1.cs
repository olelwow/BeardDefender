using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeardDefender.GameObjects
{
    internal class GroundTileFlat1 : UserControl
    {
        public GroundTileFlat1()
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
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Plan_mark1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-979, -496);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1021, 539);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // GroundTileFlat1
            // 
            BackColor = Color.Transparent;
            Controls.Add(pictureBox1);
            Name = "GroundTileFlat1";
            Size = new Size(60, 60);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
    }
}
