namespace BeardDefender
{
    partial class GameLevelTwo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            player1 = new GameObjects.Player();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SandyBrown;
            pictureBox1.Location = new Point(-7, 965);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1933, 74);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // player1
            // 
            player1.Location = new Point(48, 883);
            player1.Name = "player1";
            player1.Size = new Size(88, 49);
            player1.TabIndex = 1;
            // 
            // GameLevelTwo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.game_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(player1);
            Controls.Add(pictureBox1);
            Name = "GameLevelTwo";
            Text = "GameLevelTwo";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GameObjects.Player player1;
    }
}