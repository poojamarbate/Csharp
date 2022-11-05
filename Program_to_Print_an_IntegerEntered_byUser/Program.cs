using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_Print_an_IntegerEntered_byUser
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number:");
            number =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number is:{0} ",number);
            Console.ReadLine();
        }
    }
}
