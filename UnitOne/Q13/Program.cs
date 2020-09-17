using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        // Q13
        // Author: Joungho Seo
        // Purpose: Q12 but use struct
        // Restrictions: username must be Joungho Seo
        struct Employee
        {
            public string sName;
            public double dSalary;
            public bool GiveRaise()
            {
                Console.WriteLine("What is your name?");
                string userInput = Console.ReadLine();
                if (this.sName.Equals(userInput))
                {
                    this.dSalary += 19999.99;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        static void Main(string[] args)
        {


            Employee joungho;
            joungho.sName = "Joungho";
            joungho.dSalary = 30000;



            if (joungho.GiveRaise())
            {
                Console.WriteLine("Congrats on the raise, your new salary is = " + joungho.dSalary);
            }
            else
            {
                Console.WriteLine("RIP Raise");
            }

        }

        
    }
}
