using System;
using System.Collections.Generic;
using System.Threading;

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

            World.AddEntity(playership);
            for(int f=0; f<enemyList.Count;f++)
            {
                World.AddEntity(enemyList[f]);
            }

            EntityPositioner.PositionatePlayerShip(playership);
            EntityPositioner.PositionateEnemies(enemyList);
            int x = 0;
            while(x!=50)
            {
                Console.Clear();
                for (int f = 0; f < World.entities.Count; f++)
                {
                    
                    World.entities[f].Update();
                    
                }
                
                Graphics.DrawEntities(World.entities);
                x++;
                Thread.Sleep(300);
                
            }
            
            
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
