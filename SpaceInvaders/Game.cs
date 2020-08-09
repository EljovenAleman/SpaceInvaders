using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Game
    {
        public ConsoleKey pressedKey = ConsoleKey.Backspace;
        public void Start()
        {
            Console.CursorVisible = false;

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
            while(CheckVictory(World.entities))
            {
                
                Graphics.ClearScreen();
                                                
                Graphics.DrawEntities(World.entities);                
                

                if (Input.UserPressedGameKey())
                {
                    playership.ProcessInputAction(Input.GetInputAction()); 
                }
                
                for (int f = 0; f < World.entities.Count; f++)
                {
                    
                    World.entities[f].Update();
                    
                }
                

                x++;
                Thread.Sleep(150);
                
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

        //Quiero que devuelva un ConsoleKey (Esto obviamente no va a funcionar porque va a hacer que pare cada frame esperar por una tecla)
        //Cómo convierto a un ConsoleKeyInfo a un ConsoleKey?
        public ConsoleKey GetInput()
        {
            return Console.ReadKey().Key;
        }

        public bool CheckVictory(List<Entity> entities)
        {
            foreach(Entity entity in entities)
            {
                if(entity.position.y == 21)
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
