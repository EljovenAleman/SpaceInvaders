using System.Collections.Generic;

namespace SpaceInvaders
{
    class Game
    {
        public void Start()
        {
            PlayerShip playership = new PlayerShip();
            //World.AddEntity(playership);
            Enemy[] enemiesType0 = CreateEnemies(24, '0');
            Enemy[] enemiesType1 = CreateEnemies(24, '1');
            Enemy[] enemiesType2 = CreateEnemies(12, '2');

            List<Enemy> enemyList = new List<Enemy>();
            enemyList.AddRange(enemiesType0);
            enemyList.AddRange(enemiesType1);
            enemyList.AddRange(enemiesType2);


        }

        public Enemy[] CreateEnemies(int enemyQuantity, char enemyVisualRepresentation)
        {
            Enemy[] enemies = new Enemy[enemyQuantity];

            for(int f=0; f<enemyQuantity; f++)
            {
                Enemy enemy = new Enemy(enemyVisualRepresentation);
                //World.AddEntity(enemy);
                enemies[f]=enemy;
            }

            return enemies;
        }
    }
}
