using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
          syntax
            while(condition)
            {
            increment++/decrement ;
            }
             
             
             
             
             */
            int i = 1;
            Console.WriteLine("enter number");
            int number=int.Parse(Console.ReadLine());
            while (i <= 10)
            {
                Console.WriteLine(number+" X "+i+" = "+number*i);
                i++;
            }
            Console.WriteLine("while loop terminate");
            Console.ReadLine();

        }
    }
}
