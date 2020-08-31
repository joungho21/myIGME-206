using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4Question2
{
    class Program
    {
        // PE4 Question 2
        // Author: Joungho Seo
        // Purpose: 2.	Write a console application that includes the logic from Exercise 1 
        static void Main(string[] args)
        {
            bool loop = true;
            int num1;
            int num2;
            while (loop) //Loop to continue if user inputted number greater than 10
            {
                Console.WriteLine("Please enter an integer less than 10:");
                num1 = Convert.ToInt32(Console.ReadLine()); //Parsing string input to int

                Console.WriteLine("Please enter another integer less than 10:");
                num2 = Convert.ToInt32(Console.ReadLine()); 

                if (num1 > 10 || num2 > 10) //If any of the input is > 10
                {
                    Console.WriteLine("You entered an integer greater than 10, please try again!"); //Goes back to the loop
                }
                else
                {
                    Console.WriteLine("The Exclusive OR between " + num1 + " and " + num2 + " = " + (num1 ^ num2));
                    loop = false; //stops the loop
                }
            }
        }
    }
}
