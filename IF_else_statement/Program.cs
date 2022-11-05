using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_else_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10, number2 = 20;
            if (number < number2)
            {
                Console.WriteLine("second number is greater");
            }
            else
            {
                Console.WriteLine("first number is greater");
            }
            Console.ReadLine();
        }
    }
}
