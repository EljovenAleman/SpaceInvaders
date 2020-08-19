using System;

namespace SpaceInvaders
{
    static class ScoreBoard
    {
        static public int totalScore = 0;

        static public void ScoreCalculator(char enemyKind)
        {
            if(enemyKind == '0')
            {
                totalScore = totalScore + 20;
            }
            else if(enemyKind == '1')
            {
                totalScore = totalScore + 10;
            }
            else if ( enemyKind=='2')
            {
                totalScore = totalScore + 5;
            }
            else if (enemyKind=='>')
            {
                totalScore = totalScore + 200;
            }
        }

        static public void ShowScore()
        {
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Score: " + totalScore);
        }
    }
}
