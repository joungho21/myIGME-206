using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_Q5
{
    class Program
    {
        // PE3 Question 5
        // Author: Joungho Seo
        // Purpose: Console Application obtains 4 int values from user and display the product
        static void Main(string[] args)
        {
            int result =1; //Instantiates with 1 so that it will not conflict with the first input
            for (int i = 0; i <4; i++) { //For loop to get 4 int values
                Console.WriteLine("Please enter an integer:");
                result *=Convert.ToInt32(Console.ReadLine()); //Parsing string input to int
            }
            Console.WriteLine("The total product of those 4 interger is " + result);


        }
    }
}
