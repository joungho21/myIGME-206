using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        // Q8
        // Author: Joungho Seo
        // Purpose: 3d array
        // Restrictions: no output
        static void Main(string[] args)
        {
            double xCounter = 0;
            double yCounter = -1;
            double result;

            double[,,] multiArray = new double[20, 39, 3];
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                    multiArray[i, j, 0] = xCounter;
                    multiArray[i, j, 1] = yCounter;
                    result = (3 * multiArray[i, j, 1] * multiArray[i, j, 1]* multiArray[i, j, 1]) + (2 * multiArray[i, j, 0]* multiArray[i, j, 0])-(8 * multiArray[i, j, 0])+7;
                    multiArray[i, j, 2] = result;
                }
                xCounter += 0.1;
                yCounter += 0.1;
            }
        }
    }
}