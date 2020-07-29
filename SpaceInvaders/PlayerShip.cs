using System;
using System.Security.Cryptography.X509Certificates;

namespace SpaceInvaders
{
    class PlayerShip : Entity
    {
        public PlayerShip() : base('A')
        {

        }

        //Por qué devolvía un shot acá?
        public Shot Shoot()
        {
            int x = position.x;
            int y = position.y;
            Shot shot = new Shot(x,y,-1);

            return shot;
            
        }

        //Quería hacerlo con Switch
        //Diferencia entre ConsoleKeyInfo y ConsoleKey?
        public void Move(ConsoleKey pressedKey)
        {
            if(pressedKey==ConsoleKey.RightArrow)
            {
                GoRight();
            }
            else if(pressedKey==ConsoleKey.LeftArrow)
            {
                GoLeft();
            }
            else if(pressedKey==ConsoleKey.Spacebar)
            {
                Shoot();
            }
        }

        private void GoRight()
        {
            Move(this.position.x + 1, this.position.y);
        }

        private void GoLeft()
        {
            Move(this.position.x - 1, this.position.y);
        }

       

    }
}
