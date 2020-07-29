using System.Data;

namespace SpaceInvaders
{
    class Entity
    {
        public Position position;
        public char visualRepresentation;

        public Entity(char _visualRepresentation)
        {
            visualRepresentation = _visualRepresentation;
        }

        public void Move(int x, int y)
        {
            position.x = x;
            position.y = y;
        }

        public virtual void Update()
        {

        }

        
    }
}
