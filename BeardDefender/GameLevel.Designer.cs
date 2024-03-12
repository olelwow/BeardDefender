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
            Label_PlayerScore = new Label();
            SuspendLayout();
            // 
            // player1
            // 
            player1.BackColor = Color.Transparent;
            player1.Location = new Point(342, 890);
            player1.Margin = new Padding(0);
            player1.Name = "player1";
            player1.Score = 0;
            player1.Size = new Size(39, 73);
            player1.Speed = 5;
            player1.TabIndex = 2;
            // 
            // ground1
            // 
            ground1.BackColor = Color.Transparent;
            ground1.Location = new Point(-9, 963);
            ground1.Name = "ground1";
            ground1.Size = new Size(837, 100);
            ground1.TabIndex = 3;
            // 
            // tileCornerLeft1
            // 
            tileCornerLeft1.BackColor = Color.Transparent;
            tileCornerLeft1.Location = new Point(532, 907);
            tileCornerLeft1.Margin = new Padding(2, 3, 3, 3);
            tileCornerLeft1.Name = "tileCornerLeft1";
            tileCornerLeft1.RightToLeft = RightToLeft.No;
            tileCornerLeft1.Size = new Size(69, 56);
            tileCornerLeft1.TabIndex = 4;
            tileCornerLeft1.Tag = "object";
            // 
            // groundTileFlat11
            // 
            groundTileFlat11.BackColor = Color.Transparent;
            groundTileFlat11.Location = new Point(127, 923);
            groundTileFlat11.Name = "groundTileFlat11";
            groundTileFlat11.Size = new Size(50, 40);
            groundTileFlat11.TabIndex = 5;
            groundTileFlat11.Tag = "object";
            // 
            // Label_PlayerScore
            // 
            Label_PlayerScore.AutoSize = true;
            Label_PlayerScore.BackColor = Color.Transparent;
            Label_PlayerScore.Font = new Font("Segoe UI", 20F);
            Label_PlayerScore.Location = new Point(12, 9);
            Label_PlayerScore.Name = "Label_PlayerScore";
            Label_PlayerScore.Size = new Size(110, 37);
            Label_PlayerScore.TabIndex = 6;
            Label_PlayerScore.Text = "Score: 0";
            // 
            // GameLevel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.game_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(player1);
            Controls.Add(tileCornerLeft1);
            Controls.Add(groundTileFlat11);
            Controls.Add(ground1);
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
        private Label Label_PlayerScore;
    }
}