using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            double xCounter = -1;
            double yCounter = 1;
            double result;

            double[ , , ] multiArray = new double[20,30,3];
            for (int i = 0; i < 20; i++)
            {
                for (int j=0; j < 30; j++)
                {
                    multiArray[i, j, 0] = xCounter;
                }
                xCounter += 0.1;
            }

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 30; j++)
                {
                    multiArray[i, j, 1] = yCounter;
                }
                yCounter += 0.1;
            }

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 30; j++)
                {
                    result = (3 * multiArray[i, j, 2] * multiArray[i, j, 2]) + 2 * multiArray[i, j, 0] - 1;
                    multiArray[i, j, 3] = result;
                }
                yCounter += 0.1;
            }
        }
    }
}
