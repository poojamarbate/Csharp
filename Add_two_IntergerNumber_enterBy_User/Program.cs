using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_two_IntergerNumber_enterBy_User
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2,result;
            Console.WriteLine("Enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            result = number1 + number2;
            Console.WriteLine("Addition :{0} ",result);
            Console.ReadLine();
        }
    }
}
