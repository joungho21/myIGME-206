using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9Q3
{
    class Program
    {
        // PE9 Q3
        // Author: Joungho Seo
        // Purpose: 3.	Create a delegate function and use it to impersonate the Console.ReadLine() 
        // Restrictions: Only outputs what was inputted
        
        public delegate string myDelegate(); //declare a delegate

        static void Main()
        {
            Console.WriteLine("Please enter a message you would like to echo");
            string output = Readline(); //testing readline method from myDelegate 
            Console.WriteLine(output);
        }
         static string Readline() //readline function for myDelegate signature
        {
            return Console.ReadLine();
        }
            
        

        }
    }