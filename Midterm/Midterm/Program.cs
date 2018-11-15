using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool KeepLooping = true;
            //while (KeepLooping == true)
            {
                //Console.WriteLine("HI! IM TEST DIALOGUE AND SHOULD NOT APPEAR!");
            }
            int num2 = 2;
            while (num2 < 129)
            {
                Console.WriteLine("[" + num2 + "]");
                num2 = num2 * 2;
            }
            int num3 = 49;
            while (num3 >= 1)
            {
                Console.Write(num3 + ", ");
                num3--;
            }
            Console.WriteLine("");
            int num4 = 1;
            while (num4 <= 21)
            {
                Console.Write(num4 + "   ");
                num4 = num4 + 2;
            }
            Console.WriteLine("");
            //the following is the example Do-While Loop
            int n = 8;
            int i = 10; // initialize
                        
            /*do
                {
                    Console.Write("*");
                    i++; // update!
                } while (i < n); // test condition */

            /*The difference is that the Do-While will print the "*" regardless if the condiotion is fullfilled but only once.
            as for the While Loop will do nothing*/
            //this is the While Loop
            while (i < n)
            {
                Console.WriteLine("*");
                i++;
            }

            bool IcyRain = false;
            bool Tornado = false;
            if (IcyRain == false && Tornado == false)
            {
                Console.WriteLine("OH! Let's go outside!");
            }
            else
            {
                Console.WriteLine("ITS AWFUL OUTSIDE! lets stay in..");
            }
            Console.ReadLine();
        }
    }
}
