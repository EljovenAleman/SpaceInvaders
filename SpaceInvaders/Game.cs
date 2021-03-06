﻿using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SpaceInvaders
{
    class Game
    {
        public ConsoleKey pressedKey = ConsoleKey.Backspace;
        private bool gameWon;
        public void Start()
        {
            Console.CursorVisible = false;

            PlayerShip playership = new PlayerShip();
            
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
            
            while(CheckVictory(enemyList))
            {
                
                //Graphics.ClearScreen();

                if(RNG.RollForSpecialEnemy()==1)
                {
                    SpecialEnemy specialEnemy = new SpecialEnemy('>');
                    EntityPositioner.PositionateSpecialEnemy(specialEnemy);
                    World.AddEntity(specialEnemy);
                }
                                                
                Graphics.DrawEntities(World.entities);

                ScoreBoard.ShowScore();
                                                          
                if (Input.UserPressedGameKey())
                {
                    playership.ProcessInputAction(Input.GetInputAction());
                }

                //si DrawEntities lo pongo acá, se desarma todo, por qué?

                for (int f = 0; f < World.entities.Count; f++)
                {                    
                    World.entities[f].Update();                    
                }
                //si no pongo esto se duplica, por qué?
                Console.SetCursorPosition(0, 0);
                                             
                Thread.Sleep(10);
                
            }

            if(gameWon)
            {

                Graphics.ClearScreen();
                Console.SetCursorPosition(35, 10);
                Console.WriteLine("You win!");

                Console.SetCursorPosition(32, 20);
                Console.WriteLine("Final score: " + ScoreBoard.totalScore);
            }
            else
            {
                Graphics.ClearScreen();
                Console.SetCursorPosition(35, 10);
                Console.WriteLine("You lose");

                Console.SetCursorPosition(32, 20);
                Console.WriteLine("Final score: " + ScoreBoard.totalScore);
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

        
        public ConsoleKey GetInput()
        {
            return Console.ReadKey().Key;
        }

        public bool CheckVictory(List<Enemy> enemies)
        {
            foreach(Enemy enemy in enemies)
            {
                if(enemy.position.y == 20 && enemy.visualRepresentation != ' ')
                {
                    gameWon = false;
                    return false;
                }
            }

            int deadEnemyCounter = 0;
            foreach (Enemy enemy in enemies)
            {
                if (enemy.visualRepresentation == ' ')
                {
                    deadEnemyCounter++;
                    if(deadEnemyCounter == enemies.Count)
                    {
                        gameWon = true;
                        return false;
                    }
                }
            }

            return true;
        }

        
    }
}
