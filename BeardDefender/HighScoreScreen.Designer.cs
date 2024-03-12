namespace BeardDefender
{
    partial class HighScoreScreen
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Highscore_Grid = new DataGridView();
            Player_Column = new DataGridViewTextBoxColumn();
            Score_Column = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Highscore_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Highscore_Grid
            // 
            Highscore_Grid.AllowUserToDeleteRows = false;
            Highscore_Grid.BackgroundColor = Color.DimGray;
            Highscore_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Highscore_Grid.Columns.AddRange(new DataGridViewColumn[] { Player_Column, Score_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Highscore_Grid.DefaultCellStyle = dataGridViewCellStyle3;
            Highscore_Grid.Location = new Point(1274, 236);
            Highscore_Grid.Name = "Highscore_Grid";
            Highscore_Grid.ReadOnly = true;
            Highscore_Grid.Size = new Size(504, 295);
            Highscore_Grid.TabIndex = 0;
            // 
            // Player_Column
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            Player_Column.DefaultCellStyle = dataGridViewCellStyle1;
            Player_Column.HeaderText = "Player";
            Player_Column.Name = "Player_Column";
            Player_Column.ReadOnly = true;
            Player_Column.Resizable = DataGridViewTriState.False;
            Player_Column.Width = 230;
            // 
            // Score_Column
            // 
            dataGridViewCellStyle2.BackColor = Color.Silver;
            Score_Column.DefaultCellStyle = dataGridViewCellStyle2;
            Score_Column.HeaderText = "Score";
            Score_Column.Name = "Score_Column";
            Score_Column.ReadOnly = true;
            Score_Column.Resizable = DataGridViewTriState.False;
            Score_Column.Width = 230;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.highscore_screen;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // HighScoreScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(Highscore_Grid);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "HighScoreScreen";
            Text = "High Scores";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Highscore_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Highscore_Grid;
        private DataGridViewTextBoxColumn Player_Column;
        private DataGridViewTextBoxColumn Score_Column;
        private PictureBox pictureBox1;
    }
}