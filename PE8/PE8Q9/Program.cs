using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8Q9
{
    class Program
    {

        // Author: Joungho Seo
        // Purpose:	9.	Write a console application that places double quotes around each word in a string.
        // Restrictions: Assumes user input proper strings
        static void Main(string[] args)
        {
            String userInput ="\""; //starts with first quotes

            Console.WriteLine("Please enter a string you would like to replace no with yes");
            userInput += Console.ReadLine();

            userInput = userInput.Replace(" ", "\" \""); //converts space with quotation mark

            userInput+= "\""; //Ends last quotation mark

            Console.WriteLine(userInput);


        }
    }
}
