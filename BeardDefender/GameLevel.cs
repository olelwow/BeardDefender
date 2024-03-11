
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
            if (e.KeyCode == PlayerMovement.KeyUp)
            {
                PlayerMovement.IsUp = true;
            }
            if (e.KeyCode == PlayerMovement.KeyDown)
            {
                PlayerMovement.IsDown = true;
            }
            if (e.KeyCode == PlayerMovement.KeyRight)
            {
                PlayerMovement.IsRight = true;
            }
            if (e.KeyCode == PlayerMovement.KeyLeft)
            {
                PlayerMovement.IsLeft = true;
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == PlayerMovement.KeyUp)
            {
                PlayerMovement.IsUp = false;
            }
            if (e.KeyCode == PlayerMovement.KeyDown)
            {
                PlayerMovement.IsDown = false;
            }
            if (e.KeyCode == PlayerMovement.KeyRight)
            {
                PlayerMovement.IsRight = false;
            }
            if (e.KeyCode == PlayerMovement.KeyLeft)
            {
                PlayerMovement.IsLeft = false;
            }
        }

        private void GameLevel_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
    }
}
