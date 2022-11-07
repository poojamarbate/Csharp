using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Loops:iteration,looping,repeating.......

                     types of loops:
                               - for loop
                               - while loop
                               -do_while loop
                               -foreach loop(used with array,list collections)
            
            syntax
            for (initalization;condition,increament/decremenet)
           {

            }
             
             
             */
            //Console.WriteLine("enter any number which u want to print table");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------\n\n");

            //for(int i = 1; i <=10; i++) //counter variable
            //{
            //    Console.WriteLine(number+" X "+i+" = "+number*i);
            //}


          for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("for loop terminate...");
            Console.ReadLine();

        }
    }
}
