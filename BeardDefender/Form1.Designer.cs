namespace BeardDefender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_startGame = new Button();
            btn_scoreBoard = new Button();
            btn_quit = new Button();
            pictureBox1 = new PictureBox();
            imgList_buttonImages = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_startGame
            // 
            btn_startGame.BackColor = SystemColors.ActiveCaption;
            btn_startGame.Font = new Font("Segoe UI", 30F);
            btn_startGame.Location = new Point(362, 252);
            btn_startGame.Name = "btn_startGame";
            btn_startGame.Size = new Size(303, 84);
            btn_startGame.TabIndex = 0;
            btn_startGame.Text = "Start Game";
            btn_startGame.UseVisualStyleBackColor = false;
            // 
            // btn_scoreBoard
            // 
            btn_scoreBoard.BackColor = SystemColors.ActiveCaption;
            btn_scoreBoard.Font = new Font("Segoe UI", 30F);
            btn_scoreBoard.Location = new Point(362, 136);
            btn_scoreBoard.Name = "btn_scoreBoard";
            btn_scoreBoard.Size = new Size(303, 84);
            btn_scoreBoard.TabIndex = 1;
            btn_scoreBoard.Text = "Scoreboard";
            btn_scoreBoard.UseVisualStyleBackColor = false;
            // 
            // btn_quit
            // 
            btn_quit.BackColor = SystemColors.ActiveCaption;
            btn_quit.Font = new Font("Segoe UI", 30F);
            btn_quit.Location = new Point(362, 370);
            btn_quit.Name = "btn_quit";
            btn_quit.Size = new Size(303, 84);
            btn_quit.TabIndex = 2;
            btn_quit.Text = "Quit";
            btn_quit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1792, 1024);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // imgList_buttonImages
            // 
            imgList_buttonImages.ColorDepth = ColorDepth.Depth32Bit;
            imgList_buttonImages.ImageStream = (ImageListStreamer)resources.GetObject("imgList_buttonImages.ImageStream");
            imgList_buttonImages.TransparentColor = Color.Transparent;
            imgList_buttonImages.Images.SetKeyName(0, "Play.png");
            imgList_buttonImages.Images.SetKeyName(1, "HighScore12.png");
            imgList_buttonImages.Images.SetKeyName(2, "Quit.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 977);
            Controls.Add(pictureBox1);
            Controls.Add(btn_quit);
            Controls.Add(btn_startGame);
            Controls.Add(btn_scoreBoard);
            Name = "Form1";
            Text = "Beard Defender";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_startGame;
        private Button btn_scoreBoard;
        private Button btn_quit;
        private PictureBox pictureBox1;
        private ImageList imgList_buttonImages;
    }
}
