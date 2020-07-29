using System.Security.Cryptography.X509Certificates;

namespace SpaceInvaders
{
    class Shot : Entity
    {
        int directionY;
        public Shot(int x, int y, int directionY) : base('I')
        {
            Move(x, y+directionY);
            this.directionY = directionY;
        }


        /*public bool Colission(char[,] world, int x, int y)
        {
            //quiero que chequee si esa posición en world está vacía
            if(world[x,y-1]==null)
            {
                return false;
            }

            return true;
        }

        public void Explode(char[,] world, int x, int y)
        {
            world[x, y - 1] = 'X';
        }*/

        public override void Update()
        {
            Move(position.x, position.y + directionY);
        }

    }
}
