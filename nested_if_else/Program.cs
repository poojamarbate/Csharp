using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            if (a < 5)
            {
                if (a == 10)
                {
                    Console.WriteLine("a is 10");
                }
                else
                {
                    Console.WriteLine("a is not 10");
                }
            }
            else
            {
              Console.WriteLine("a is lesser");
            }
            Console.ReadLine();
        }
    }
}
