using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            /* Compile time Error
             * int nY
             * Missing semi colon and added 0 to allow usage without instantiating any number */
            int nY =0;
            int nAnswer;

            /* Compile time Error
             * Console.WriteLine(This program calculates x ^ y.);
             * Missing quotation mark */
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                /* Logic Error
                 * Console.ReadLine();
                * will not append user input to any variable */
                sNumber =Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY));

            // compute the factorial of the number using a recursive function
            nAnswer = Power(nX, nY);

            /* Logic Error
            * Console.WriteLine("{nX}^{nY} = {nAnswer}");
            * console will not write those variables */
            Console.WriteLine("{"+nX+"}^{"+nY+"} = {"+nAnswer+"}");
        }

        /* logic Error
         * int Power(int nBase, int nExponent)
         * main will not be able to call Power method */
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                /* Logic error
                * returnVal;
                * simplified recursion to line 69*/
                return 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                /* Run Time Error
                * nextVal = Power(nBase, nExponent + 1); and returnVal = nBase * nextVal;
                * needs to return decrement instead of increment and simplified recursion*/
                return nBase * Power(nBase, nExponent - 1);

            }
            /* Logic error
            * returnVal;
            * simplified recursion to line 69*/
        }
    }
}
