using System;
using System.Runtime.InteropServices;

namespace SpaceInvaders
{
    static class Input
    {
        static ConsoleKey inputActionKey;
        static bool keyAvailable;
        
        public static bool UserPressedGameKey()
        {
            if (keyAvailable)
            {
                return true;
            }

            if (Console.KeyAvailable)
            {
                ConsoleKey pressedKey = Console.ReadKey(true).Key;

                if(pressedKey==ConsoleKey.RightArrow ||
                    pressedKey==ConsoleKey.LeftArrow ||
                    pressedKey==ConsoleKey.Spacebar)
                {
                    keyAvailable = true;
                    inputActionKey = pressedKey;
                    return true;
                }
            }

            return false;
        }

        public static InputAction GetInputAction()
        {
            if(inputActionKey==ConsoleKey.RightArrow)
            {
                keyAvailable = false;
                inputActionKey = ConsoleKey.Y;
                return InputAction.MoveRight;
            }
            else if (inputActionKey == ConsoleKey.LeftArrow)
            {
                keyAvailable = false;
                inputActionKey = ConsoleKey.Y;
                return InputAction.MoveLeft;
            }
            else if (inputActionKey == ConsoleKey.Spacebar)
            {
                keyAvailable = false;
                inputActionKey = ConsoleKey.Y;
                return InputAction.Shoot;
            }

            return InputAction.None;
        }
    }
}
