using System.Collections.Generic;

namespace SpaceInvaders
{
    static class EntityPositioner
    {
        public static void PositionatePlayerShip(PlayerShip playership)
        {
            playership.Move(20, 40);
        }

        //Cambios en la posición de los enemigos, ahora son 5 filas de 12 enemigos, separando los tipos de enemigo por fila
        public static void PositionateEnemies(List<Enemy> enemies)
        {
            int positionOnTheList = 0;
            for(int f=0; f<3; f=f+2)
            {
                for(int c=0; c<25; c=c+2)
                {
                    enemies[positionOnTheList].Move(f, c);
                    positionOnTheList++;
                }
            }
        }
    }
}
