using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_Compute_Quotient_andRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend,divisor, remainder, quotient;
            Console.WriteLine("enter dividend value");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  divisor value");
            divisor = Convert.ToInt32(Console.ReadLine());
            remainder = dividend % divisor;
            quotient = dividend / divisor;
            Console.WriteLine("Remainder: {0}",remainder);
            Console.WriteLine("Quotient:{0}",quotient);
            Console.ReadLine();

        }
    }
}
