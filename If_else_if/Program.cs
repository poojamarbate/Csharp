using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter percentage:");
            int per = int.Parse(Console.ReadLine());
            if (per >= 80)
            {
                Console.WriteLine("A_1");
            }
           else if(per>=70)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("third division");
            }
            Console.ReadLine();
        }
    }
}
