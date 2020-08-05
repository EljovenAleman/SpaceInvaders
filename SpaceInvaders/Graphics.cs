using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
    static class Graphics
    {
        

        private static int width = 40, height = 40;
        private static string clearString = CreateClearString();

        public static void DrawEntities(List<Entity> entities)
        {
            foreach(Entity drawableEntity in entities)
            {
                DrawEntity(drawableEntity);
            }
        }

        private static void DrawEntity(Entity entity)
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
