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
        
        public void ProcessInputAction(InputAction pressedKey)
        {
            if(pressedKey==InputAction.MoveRight)
            {
                GoRight();
            }
            else if(pressedKey== InputAction.MoveLeft)
            {
                GoLeft();
            }
            else if(pressedKey== InputAction.Shoot)
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
