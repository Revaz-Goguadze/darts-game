using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));

            if (distance > 10)
            {
                return 0;
            }
            else if (distance > 5)
            {
                return 1;
            }
            else if (distance > 1)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }
    }
}
