using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MadLibs
{
    class Program
    {
        // Mad Libs PE
        // Author: Hint Provided by Professor David Schuh, Edited further by Joungho Seo
        // Purpose: Text File I/O functions
        // Restrictions: MadLibsTemplate.txt has to be in the debug folder in the project directory
        // Restrictions: Assumes user would input interger for the 1-n madlib. Doesn't check for invalid input as it was not asked to be implemented
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;
            string userName;
            StreamReader input;
            bool loop = true;
            string userInteract = null; //Used to hold string for user input or output
            String resultString = ""; //used to hold final result string
           

            Console.WriteLine("Would you like to play the Mad Libs Game? Type yes or no (case insensitive)");
            
            while (loop)
            {
                
                userInteract = Console.ReadLine(); 

                if (String.Equals(userInteract, "no", StringComparison.OrdinalIgnoreCase)) 
                {
                    Console.WriteLine("okay, goodbye");
                    loop = false; //stops loop
                }
                else if (String.Equals(userInteract, "yes", StringComparison.OrdinalIgnoreCase))
                {
                    // open the template file to count how many Mad Libs it contains
                    input = new StreamReader("MadLibsTemplate.txt"); //Changed so that it would read from the same directory as debug folder

                    string line = null;
                    while ((line = input.ReadLine()) != null)
                    {
                        ++numLibs; //count how many lines so we know how big the array needs to be
                    }

                    // close it
                    input.Close();

                    // only allocate as many strings as there are Mad Libs
                    string[] madLibs = new string[numLibs];

                    // read the Mad Libs into the array of strings
                    input = new StreamReader("MadLibsTemplate.txt"); //read line 25

                    line = null;
                    while ((line = input.ReadLine()) != null)
                    {
                        // set this array element to the current line of the template file
                        madLibs[cntr] = line;

                        // replace the "\\n" tag with the newline escape character
                        madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                        ++cntr;
                    }

                    input.Close();

                    // prompt the user for which Mad Lib they want to play (nChoice)
                    Console.WriteLine("Please enter your name: ");
                    userName = Console.ReadLine();

                    Console.WriteLine(userName+", please enter which mad lib you wish to play from 1-6"); //there are 6 madlibs
                    nChoice = Convert.ToInt32(Console.ReadLine());
                    nChoice -= 1; //-1 increment since machine counts from 0
                    // split the Mad Lib into separate words
                    string[] words = madLibs[nChoice].Split(' ');

     
                    foreach (string word in words)
                    {
                        //userInteract is used instead of word since word can't be saved
                        userInteract = word; //Cleans buffer every next loop
                        
                        // if word is a placeholder
                        if (userInteract.Contains("{"))
                        {
                            userInteract=userInteract.Replace("{", "");
                            userInteract=userInteract.Replace("}", "");
                            /* Since number 8. Says to use string replace to remove underscore and not include {}, 
                             * I assumed commas should not appear in prompt but should be in the final madlib 
                             * as it is part of punctuation not a choice
                             * Sidenote: I'm 100% sure I can refactor this code to keep it simple
                             * However I'm drawing a blank right now but this solution works */

                            if (userInteract.Contains("_") && userInteract.Contains(","))  //if word contains underscore and comma
                            {
                                userInteract = userInteract.Replace("_", " ");
                                userInteract = userInteract.Replace(",", "");
                                Console.Write("Replace a word for " + userInteract + ":");
                                resultString += Console.ReadLine() + ", ";
                            }
                            else if (userInteract.Contains(","))
                            {
                                userInteract = userInteract.Replace(",", "");
                                Console.Write("Replace a word for " + userInteract + ":");
                                resultString += Console.ReadLine() + ", ";
                            }
                            else if (userInteract.Contains("_"))
                            {
                                userInteract = userInteract.Replace(",", " ");
                                Console.Write("Replace a word for " + userInteract + ":");
                                resultString += Console.ReadLine() + " ";
                            }
                            else
                            {
                                Console.Write("Replace a word for " + userInteract + ":");
                                resultString += Console.ReadLine() + " ";
                            }


                        }
                        else
                        { // else append word to the result string
                            if (word.Contains("\n")) //If we reached the end of the line, we shouldnt add a space
                            {
                                resultString += word;
                            }
                            else //For nomal words, we need space in between
                            {
                                resultString += word + " ";
                            }
                        }
                    }
                    Console.WriteLine(resultString);
                    loop = false;
                }
                else //If user did not input that matches yes/no
                {
                    Console.WriteLine("Please type yes/no");
                }
            }

            
            }
            
            
        
    }
}
