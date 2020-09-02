using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6Parsing
{
    class Program
    {
        // PE6 Implementation
        // Author: Joungho Seo
        // Purpose:Simple number guessing game. The program will generate a random integer number between 0 and 100 (inclusive) and the player will try to guess it. 
        // Date: 9/2/2020
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 101); //Generates random number between 0-100

            int userInput = 0; //Instantiate userInput to hold the input
            int i = 0; //Instantiate to allow use outside for loop

            Console.WriteLine(randomNumber); //Display the random number

            for (i = 1 ; i < 9; i++) //For loop to give the user 8 tries. 
                //Starts with i=1 since humans don't count from 0
            {
                Console.WriteLine("Turn #" + i + ": Enter your guess: ");
                userInput = Convert.ToInt32(Console.ReadLine()); //Parsing string input to int
                if(userInput >100 || userInput < 0)
                {
                    Console.WriteLine("Invalid guess - try again");
                        i--; //Decrement so it doesn't use up a try
                }
                else if (userInput > randomNumber) //if userInput is greater than random number
                {
                    Console.WriteLine("Too High");
                }
                else if (userInput < randomNumber) //When userInput is less than random Number
                {
                    Console.WriteLine("Too Low");
                }
                else //When UserInput = RandomNumber
                {
                    Console.WriteLine("Correct! You won in "+i+" turns");
                    i = 10; //To stop the loop if 8 tries have not been used up.
                }
            }
            if (i == 9) //If user used up all the 8 tries and fail to guess
            {
                Console.WriteLine("You ran out of turns. The number was " + randomNumber);
            }
        }
    }
}
