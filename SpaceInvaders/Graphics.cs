using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
    static class Graphics
    {
        private static int width = 40, height = 40;

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
            for(int f=0; f<width;f++)
            {
                for(int c=0; c<height;c++)
                {
                    Console.SetCursorPosition(f, c);
                    Console.Write(' ');
                }
            }
        }
    }
}
