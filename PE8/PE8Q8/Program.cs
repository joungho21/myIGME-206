using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8Q8
{
    class Program
    {

        // Author: Joungho Seo
        // Purpose:8.	Write a console application that accepts a string and replaces all occurrences of the string "no" with "yes".
        // Restrictions: Assumes user input proper strings
        static void Main(string[] args)
        {
            String userInput;

            Console.WriteLine("Please enter a string you would like to replace no with yes");
            userInput = Console.ReadLine();

            userInput = userInput.Replace("no", "yes"); //converts all no with yes

            Console.WriteLine(userInput);

            
        }
    }
}
