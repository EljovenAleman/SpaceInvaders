using System.Collections.Generic;

namespace SpaceInvaders
{
    static class EntityPositioner
    {
        public static void PositionatePlayerShip(PlayerShip playership)
        {
            playership.Move(20, 20);
        }

        //Cambios en la posición de los enemigos, ahora son 5 filas de 12 enemigos, separando los tipos de enemigo por fila
        public static void PositionateEnemies(List<Enemy> enemies)
        {
            int positionOnTheList = 0;
            for(int y=0; y<10; y=y+2)
            {
                for(int x=0; x<24; x=x+2)
                {
                    enemies[positionOnTheList].Move(x, y);
                    positionOnTheList++;
                }
            }
        }
    }
}
