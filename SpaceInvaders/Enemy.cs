using System.Collections.Generic;

namespace SpaceInvaders
{
    class Enemy : Entity
    {
        int movedRight = 0;
        int movedLeft = 17;

        public Enemy(char visualRepresentation): base(visualRepresentation)
        {
           
        }

        //Movimiento de los Enemies
        public override void Update()
        {

            //Move(position.x + 1, position.y);
            

            if (movedRight == 16)
            {
                Move(position.x, position.y + 1);
                movedLeft = 0;
                movedRight++;
            }
            else if (movedLeft == 16)
            {
                Move(position.x, position.y + 1);
                movedRight = 0;
                movedLeft++;
            }
            else if (movedRight < 16)
            {
                Move(position.x + 1, position.y);
                movedRight++;

            }
            else if(movedLeft < 16)
            {
                Move(position.x - 1, position.y);
                movedLeft++;
            }
           
        }

        public void GoRight(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Move(enemies[i].position.x + 1, enemies[i].position.y);
            }
        }

        public void GoLeft(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Move(enemies[i].position.x - 1, enemies[i].position.y);
            }
        }

        public void GoDown(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Move(enemies[i].position.x, enemies[i].position.y + 1);
            }
        }

    }
}
