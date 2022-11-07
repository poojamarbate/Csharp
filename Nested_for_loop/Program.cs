using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i <= 3; i++)
            {
                Console.WriteLine("hello");
                for(int j = 0; j <= 3; j++)
                {
                    Console.WriteLine("hey...");
                }
            }
            Console.WriteLine("loop terminate");   //used:multi demisional array

            Console.ReadLine();
        }
    }
}
