using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        // Q12
        // Author: Joungho Seo
        // Purpose: Q12
        // Restrictions: username must be Joungho Seo
        static void Main(string[] args)
        {
            string sName = "Joungho" ;
            double dSalary = 30000;

            
             if (GiveRaise(sName , ref dSalary))
            {
                Console.WriteLine("Congrats on the raise, your new salary is = " + dSalary);
            }
            else
            {
                Console.WriteLine("RIP Raise");
            }
            
        }

        static bool GiveRaise(string name, ref double salary)
        {
            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();
            if (name.Equals(userInput)){
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
