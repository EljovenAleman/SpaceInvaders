using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
    static class Graphics
    {
        private static char[,] matrix = new char[40, 71];

        private static int width = 40, height = 40;
        private static string clearString = CreateClearString();

        /*public static void DrawEntities(List<Entity> entities)
        {
            foreach(Entity drawableEntity in entities)
            {
                DrawEntity(drawableEntity);
            }
        }*/

        public static void DrawEntities(List<Entity> entities)
        {
            for(int f=0; f<21; f++)
            {
                for(int c=0; c<70; c++)
                {
                    matrix[f, c] = ' ';
                }
            }

            foreach(Entity entity in entities)
            {
                matrix[entity.position.y, entity.position.x] = entity.visualRepresentation;
            }

            for (int f = 0; f < 22; f++)
            {
                for (int c = 0; c < 70; c++)
                {
                    Console.Write(matrix[f, c]);
                }
                Console.WriteLine();
            }


        }


        public static void DrawEntity(Entity entity)
        {
            Console.SetCursorPosition(entity.position.x, entity.position.y);
            Console.Write(entity.visualRepresentation);
        }

        public static void ClearScreen()
        {
           
            Console.Clear();
            /*for (int f = 0; f < height; f++)
            {
                for (int c = 0; c < width; c++)
                {
                    Console.SetCursorPosition(c, f);
                    Console.Write(' ');
                }
                
            }*/
        }

        private static string CreateClearString()
        {
            string clearString = "";

            for (int f = 0; f < height; f++)
            {
                for (int c = 0; c < width; c++)
                {

                    clearString += ' ';
                }
                clearString += Environment.NewLine;
            }

            return clearString;
        }
    }
}
