using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_TwoFloatingpoint_number
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, product;
            Console.WriteLine("multiply two float number");
            Console.WriteLine("enter first number");
            number1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter second number");
            number2 = Convert.ToSingle(Console.ReadLine());
            product = number1 * number2;
            Console.WriteLine("Product: {0}",product);
            Console.ReadLine();
        }
    }
}
