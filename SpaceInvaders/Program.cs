using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Game game = new Game();
            game.Start();
        }
    }
}
