
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeardDefender
{
    public partial class GameLevel : Form
    {
        public GameLevel()
        {
            InitializeComponent();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            PlayerMovement.OnKeyDownMove(e);
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            PlayerMovement.OnKeyUpMove(e);
        }

        private void GameLevel_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
    }
}
