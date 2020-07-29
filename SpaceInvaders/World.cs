using System.Collections.Generic;
namespace SpaceInvaders
{
    static class World
    {
        static List<Entity> entities = new List<Entity>();

        

        static public void AddEntity(Entity entity)
        {
            entities.Add(entity);
        }
    }


}
