using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Decrecment_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            Console.WriteLine(number++); //post increment
            Console.WriteLine(number);

            Console.WriteLine(number--);

            int number2 = 99;
            Console.WriteLine(++number2);


            Console.ReadKey();
        }
    }
}
