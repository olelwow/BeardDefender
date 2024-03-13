using BeardDefender.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeardDefender
{
    public abstract class PlayerMovement
    {
        public readonly static Keys KeyUp = Keys.W;
        public readonly static Keys KeyDown = Keys.S;
        public readonly static Keys KeyLeft = Keys.A;
        public readonly static Keys KeyRight = Keys.D;

        public static bool IsUp = false;
        public static bool IsDown = false;
        public static bool IsLeft = false;
        public static bool IsRight = false;

        public static void OnKeyDownMove(KeyEventArgs e, Player player)
        {
            //player.Speed = player.startingSpeed;
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

        public static void OnKeyUpMove(KeyEventArgs e)
        {
            if (e.KeyCode == PlayerMovement.KeyUp )
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
    }
}
