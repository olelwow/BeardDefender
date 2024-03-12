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
            Ground = new PictureBox();
            player1 = new GameObjects.Player();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            SuspendLayout();
            // 
            // Ground
            // 
            Ground.BackColor = Color.Tan;
            Ground.Location = new Point(-41, 930);
            Ground.Name = "Ground";
            Ground.Size = new Size(1970, 120);
            Ground.TabIndex = 1;
            Ground.TabStop = false;
            // 
            // player1
            // 
            player1.Location = new Point(92, 814);
            player1.Name = "player1";
            player1.Size = new Size(57, 48);
            player1.TabIndex = 2;
            // 
            // GameLevel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.game_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(player1);
            Controls.Add(Ground);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1792, 1018);
            Name = "GameLevel";
            Text = "GameLevel";
            WindowState = FormWindowState.Maximized;
            Load += GameLevel_Load;
            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox Ground;
        private GameObjects.Player player1;
    }
}