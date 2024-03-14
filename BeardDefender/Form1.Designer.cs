﻿namespace BeardDefender
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
            pictureBox1 = new PictureBox();
            imgList_buttonImages = new ImageList(components);
            Btn_Play = new Button();
            Btn_HighScore = new Button();
            Btn_exitGame = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1930, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            // Btn_Play
            // 
            Btn_Play.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Play.Image = (Image)resources.GetObject("Btn_Play.Image");
            Btn_Play.Location = new Point(884, 562);
            Btn_Play.Name = "Btn_Play";
            Btn_Play.Size = new Size(209, 88);
            Btn_Play.TabIndex = 1;
            Btn_Play.Text = "PLAY!";
            Btn_Play.UseVisualStyleBackColor = true;
            Btn_Play.Click += Btn_Play_Click;
            Btn_Play.MouseLeave += Btn_Play_MouseLeave;
            Btn_Play.MouseHover += Btn_Play_MouseHover_1;
            // 
            // Btn_HighScore
            // 
            Btn_HighScore.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_HighScore.Image = (Image)resources.GetObject("Btn_HighScore.Image");
            Btn_HighScore.Location = new Point(837, 722);
            Btn_HighScore.Name = "Btn_HighScore";
            Btn_HighScore.Size = new Size(292, 73);
            Btn_HighScore.TabIndex = 2;
            Btn_HighScore.Text = "HIGHSCORE";
            Btn_HighScore.UseVisualStyleBackColor = true;
            Btn_HighScore.Click += Btn_HighScore_Click;
            Btn_HighScore.MouseLeave += Btn_HighScore_MouseLeave;
            Btn_HighScore.MouseHover += Btn_HighScore_MouseHover;
            // 
            // Btn_exitGame
            // 
            Btn_exitGame.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_exitGame.Image = (Image)resources.GetObject("Btn_exitGame.Image");
            Btn_exitGame.Location = new Point(837, 877);
            Btn_exitGame.Name = "Btn_exitGame";
            Btn_exitGame.Size = new Size(292, 76);
            Btn_exitGame.TabIndex = 3;
            Btn_exitGame.Text = "EXIT GAME";
            Btn_exitGame.UseVisualStyleBackColor = true;
            Btn_exitGame.Click += Btn_exitGame_Click;
            Btn_exitGame.MouseLeave += Btn_exitGame_MouseLeave;
            Btn_exitGame.MouseHover += Btn_exitGame_MouseHover;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1904, 1033);
            Controls.Add(Btn_exitGame);
            Controls.Add(Btn_HighScore);
            Controls.Add(Btn_Play);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1792, 1018);
            Name = "Form1";
            Text = "Beard Defender";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ImageList imgList_buttonImages;
        private Button Btn_Play;
        private Button Btn_HighScore;
        private Button Btn_exitGame;
    }
}
