using BeardDefender.Properties;

namespace BeardDefender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Btn_Play.FlatAppearance.BorderSize = 0; // Ingen kant
            Btn_Play.FlatStyle = FlatStyle.Flat;
            Btn_HighScore.FlatAppearance.BorderSize = 0;
            Btn_HighScore.FlatStyle = FlatStyle.Flat;
            Btn_exitGame.FlatAppearance.BorderSize = 0;
            Btn_exitGame.FlatStyle = FlatStyle.Flat;

            Btn_Play.GotFocus += Btn_Play_GotFocus;
            Btn_Play.LostFocus += Btn_Play_LostFocus;

            Btn_HighScore.GotFocus += Btn_HighScore_GotFocus;
            Btn_HighScore.LostFocus += Btn_HighScore_LostFocus;

            Btn_exitGame.GotFocus += Btn_exitGame_GotFocus;
            Btn_exitGame.LostFocus += Btn_exitGame_LostFocus;

            //Btn_Play.Click += MenuButtons.Btn_Play_Click();

        }

        private void menu_bg_Click(object sender, EventArgs e)
        {

        }

        // Play knapp 
        private void Btn_Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            var levelOne = new GameLevel();
            levelOne.FormClosed += (s, args) => this.Close();
            levelOne.Show();
        }
        private void Btn_Play_MouseHover_1(object sender, EventArgs e)
        {

            Btn_Play.ForeColor = Color.Red;

        }

        private void Btn_Play_MouseLeave(object sender, EventArgs e)
        {
            Btn_Play.ForeColor = Color.Black;
        }

        private void Btn_Play_GotFocus(object sender, EventArgs e)
        {
            Btn_Play.ForeColor = Color.Red;
        }

        private void Btn_Play_LostFocus(object sender, EventArgs e)
        {
            Btn_Play.ForeColor = Color.Black;
        }

        // Highscore knapp 
        private void Btn_HighScore_Click(object sender, EventArgs e)
        {

        }
        private void Btn_HighScore_MouseHover(object sender, EventArgs e)
        {
            Btn_HighScore.ForeColor = Color.Red;
        }

        private void Btn_HighScore_MouseLeave(object sender, EventArgs e)
        {
            Btn_HighScore.ForeColor = Color.Black;
        }

        private void Btn_HighScore_GotFocus(object sender, EventArgs e)
        {
            Btn_HighScore.ForeColor = Color.Red;

        }

        private void Btn_HighScore_LostFocus(object sender, EventArgs e)
        {
            Btn_HighScore.ForeColor = Color.Black;
        }

        // Exit knapp 
        private void Btn_exitGame_MouseHover(object sender, EventArgs e)
        {

            Btn_exitGame.ForeColor = Color.Red;
        }

        private void Btn_exitGame_MouseLeave(object sender, EventArgs e)
        {
            Btn_exitGame.ForeColor = Color.Black;
        }

        private void Btn_exitGame_GotFocus(object sender, EventArgs e)
        {
            Btn_exitGame.ForeColor = Color.Red;
        }

        private void Btn_exitGame_LostFocus(object sender, EventArgs e)
        {
            Btn_exitGame.ForeColor = Color.Black;
        }

        
    }
}
