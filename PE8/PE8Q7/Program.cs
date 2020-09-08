using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8Q7
{
    class Program
    {

        // Author: Joungho Seo
        // Purpose:Write a console application that accepts a string from the user and outputs a string with the characters in reverse order.
        // Restrictions: Assumes user input proper strings
        static void Main(string[] args)
        {
            String userInput;
            
            Console.WriteLine("Please enter a string you would like to reverse");
            userInput = Console.ReadLine();

            char[] array = userInput.ToCharArray();

            for (int i=array.Length-1; i>=0; i--) //Go through the array but in reverse order
            {
                Console.Write(array[i]);
            }

        }
    }
}
