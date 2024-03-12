namespace BeardDefender
{
    partial class GameLevel
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
            player1 = new GameObjects.Player();
            ground1 = new GameObjects.Ground();
            tileCornerLeft1 = new GameObjects.TileCornerLeft();
            groundTileFlat11 = new GameObjects.GroundTileFlat1();
            SuspendLayout();
            // 
            // player1
            // 
            player1.Location = new Point(12, 923);
            player1.Name = "player1";
            player1.Size = new Size(57, 48);
            player1.TabIndex = 2;
            // 
            // ground1
            // 
            ground1.Location = new Point(-9, 963);
            ground1.Name = "ground1";
            ground1.Size = new Size(837, 100);
            ground1.TabIndex = 3;
            // 
            // tileCornerLeft1
            // 
            tileCornerLeft1.Location = new Point(805, 894);
            tileCornerLeft1.Name = "tileCornerLeft1";
            tileCornerLeft1.Size = new Size(23, 24);
            tileCornerLeft1.TabIndex = 4;
            // 
            // groundTileFlat11
            // 
            groundTileFlat11.Location = new Point(866, 894);
            groundTileFlat11.Name = "groundTileFlat11";
            groundTileFlat11.Size = new Size(23, 26);
            groundTileFlat11.TabIndex = 5;
            // 
            // GameLevel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.game_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groundTileFlat11);
            Controls.Add(tileCornerLeft1);
            Controls.Add(ground1);
            Controls.Add(player1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1792, 1018);
            Name = "GameLevel";
            Text = "GameLevel";
            WindowState = FormWindowState.Maximized;
            Load += GameLevel_Load;
            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;
            ResumeLayout(false);
        }

        #endregion
        private GameObjects.Player player1;
        private GameObjects.Ground ground1;
        private GameObjects.TileCornerLeft tileCornerLeft1;
        private GameObjects.GroundTileFlat1 groundTileFlat11;
    }
}