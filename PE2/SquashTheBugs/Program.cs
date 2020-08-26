using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    // Edited by: Joungho Seo
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter

            /* int i = 0
             * Error: Compile Time Error
             * Missing Semi Colon
             * */
            int i = 0;

            string allNumbers = null; //read line 39 for placement explanation

            // loop through the numbers 1 through 10

            /* for (i = 1; i < 10; i++)
             * Error: Logic Error
             * Since it stops when i<10, it will stop the loop when i=9
             */
            for (i = 1; i <= 10; i++)
            {
                // declare string to hold all numbers
                
                /* string allNumbers = null;
                 * Error: Logic Error
                 * Since allNumbers is instantiated every loop, nothing is stored
                 * thus it has to be stored outside the loop
                 */

            // output explanation of calculation

            /* Console.Write(i + "/" + i - 1 + " = ");
             * Error: Compile Time Error
             * i-1 must have a parentheses for the i-1 operator
             */
            Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers

                /* Console.WriteLine(i / (i - 1));
                 * Error: Runtime Error
                 * When i=1, it will attempt to divide by 0 
                 * thus either if or try catch can be implemented
                 */
                if (i == 1)
                {
                    Console.WriteLine("Division by 0 results undefined");
                }
                else
                {
                    Console.WriteLine(i / (i - 1));
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter

                /* i = i + 1;
                 * Error: Logic Error
                 * Since this is under a for loop, no increment is required
                 */
            }

            // output all numbers which have been processed

            /*Console.WriteLine("These numbers have been processed: " allNumbers);
             * Error: Compile Time Error
             * Requires + between "These...processed:" and allNumbers
             */
                Console.WriteLine("These numbers have been processed: "+allNumbers);
        }
    }
}
