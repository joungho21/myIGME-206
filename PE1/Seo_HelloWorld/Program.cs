/*
 * Author: Joungho Seo
 * Date: 8/24/2020
 * Assigment PE1
 * Simple Hello World Console App with variable and for loop test
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joungho Seo");
            int a = 5;
            double b = 4.9;
            Console.WriteLine("a+b " + (a + b));

            var c = 5;
            var d = 4.9;
            Console.WriteLine("c+d " + (c + d));

            int[] myNum = new int[2];
            myNum[0] = a;
            myNum[1] = c;
            c = 10;

            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }

        }
    }
}
