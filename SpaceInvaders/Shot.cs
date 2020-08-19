using System.CodeDom;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SpaceInvaders
{
    class Shot : Entity
    {
        int directionY;
        int entityFinder = 0;

        public Shot(int x, int y, int directionY) : base('l')
        {
            Move(x, y+directionY);
            this.directionY = directionY;
            World.AddEntity(this);
        }


        public bool CheckColission(List<Entity> entities)
        {
            //quiero que chequee si esa posición en world está vacía
            foreach(Entity entity in entities)
            {
                if(entity.position.x == this.position.x && entity.position.y == this.position.y)
                {
                    if(entity!=this && entity.visualRepresentation!= ' ')
                    {
                        return true;
                    }
                    return false;
                }
            }

            return false;
        }

        public void Explode(List<Entity> entities)
        {           
            visualRepresentation = 'X';
            foreach(Entity entity in entities)
            {
                if (entity.position.x == this.position.x && entity.position.y == this.position.y)
                {
                    if (entity != this)
                    {
                        ScoreBoard.ScoreCalculator(entity.visualRepresentation);
                        //entities.RemoveAt(entityFinder);
                        entity.visualRepresentation = ' ';
                        
                    }
                    
                }
                //entityFinder++;
            }
        }

        //Cómo destruyo el objeto cuando llega a la position.y = 0?
        public override void Update()
        {
            if(position.y==0)
            {
               //si la posicion es y=0 en vez de subir lo hace "desaparecer"
               visualRepresentation = ' ';
            }
            else if(visualRepresentation == 'X')
            {
                visualRepresentation = ' ';
                this.position.y = 0;
            }
            else if(CheckColission(World.entities))
            {
                Explode(World.entities);
            }
            else
            {
                Move(position.x, position.y + directionY);
            }
            
            
        }

    }
}
