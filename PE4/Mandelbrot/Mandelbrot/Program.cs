using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    // PE4 Question 6
    // Author: Joungho Seo
    // Purpose:6.	An exercise in understanding and modifying (hopefully) interesting code from "Beginning C#" by Karli Watson.
    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            bool loop = true;
            /* Instantiates with 0 since c# assumes unassigned local variable (if loop is not assumed to gone through) */
            double imagStart=0;
            double imagEnd=0;
            double realStart=0;
            double realEnd = 0;
            double imagInc = 0;
            double realInc = 0;

            while (loop) //Loop to continue if user inputted invalid values
            {
                Console.WriteLine("Imaginary coordinate will generate 48 lines, thus increment will be adjusted based on input");

                Console.WriteLine("Please enter the starting point for imaginary Coordiante ");
                imagStart = Convert.ToDouble(Console.ReadLine()); //Parsing string input to double
                
                Console.WriteLine("Please enter the end point for imaginary Coordiante ");
                imagEnd = Convert.ToDouble(Console.ReadLine()); //Parsing string input to double

                Console.WriteLine("Real Coordinate generates 80 character on each line of the image, thus increment will be adjusted accordingly ");

                Console.WriteLine("Please enter the starting point for real Coordiante ");
                realStart = Convert.ToDouble(Console.ReadLine()); //Parsing string input to double

                Console.WriteLine("Please enter the end point for real Coordiante ");
                realEnd = Convert.ToDouble(Console.ReadLine()); //Parsing string input to double

                if (imagStart < imagEnd || realEnd < realStart) //If any of the input is > 10
                {
                    Console.WriteLine("Invalid inputs are added, please ensure start point for imaginary is bigger than end point");
                    Console.WriteLine("Or the start point of real coordinate has to be lower than the end point");
                }
                else
                {
                    Console.WriteLine("You entered valid arguments");
                    imagInc = (imagStart - imagEnd) / 48; //get imaginary increment
                    realInc = (realEnd-realStart) / 80; //get real increment
                    loop = false; //stops the loop
                }
            }


            for (imagCoord = imagStart; imagCoord >= imagEnd; imagCoord -= imagInc)
            {
                for (realCoord = realStart; realCoord <= realEnd; realCoord += realInc)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
