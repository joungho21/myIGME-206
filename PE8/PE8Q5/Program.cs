using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8Q5
{
    class Program
    {
        // PE8 Q5
        // Author: Joungho Seo
        // Purpose: 3d array
        // Restrictions: no output
        static void Main(string[] args)
        {
            double xCounter = -1;
            double yCounter = 1;
            double result;

            double[ , , ] multiArray = new double[20,30,3];
            for (int i = 0; i <= 19; i++)
            {
                for (int j=0; j <= 29; j++)
                {
                    multiArray[i, j, 0] = xCounter;
                }
                xCounter += 0.1;
            }

            for (int i = 0; i <= 19; i++)
            {
                for (int j = 0; j <= 29; j++)
                {
                    multiArray[i, j, 1] = yCounter;
                }
                yCounter += 0.1;
            }

            for (int i = 0; i <= 19; i++)
            {
                for (int j = 0; j <= 29; j++)
                {
                    result = (3 * multiArray[i, j, 0] * multiArray[i, j, 0]) + 2 * multiArray[i, j, 1] - 1;
                    multiArray[i, j, 2] = result;
                }
                
            }
        }
    }
}
