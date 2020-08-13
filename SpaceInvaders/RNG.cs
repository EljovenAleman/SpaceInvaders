using System;

namespace SpaceInvaders
{
    static class RNG
    {
        static Random numberGenerator = new Random();

        static public int RollForSpecialEnemy()
        {
            int randomNumber = numberGenerator.Next(1, 301);

            return randomNumber;
        }

        
    }
}
