using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restart_program_with_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //string confirm;
            //do {
            //    Console.WriteLine("Enter first number:");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number:");
            //    int num2 = int.Parse(Console.ReadLine());
            //    int Add = num1 + num2;
            //    Console.WriteLine("Addition result is: {0}", Add);
            //    Console.WriteLine("do you want repeat your program? Yes/No");
            //    confirm = Console.ReadLine().ToLower();
            //} while (confirm=="yes");





            while (true)
            {
                Console.WriteLine("Enter first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int num2 = int.Parse(Console.ReadLine());
                int Add = num1 + num2;
                Console.WriteLine("Addition result is: {0}", Add);
                Console.WriteLine("do you want repeat your program? Yes/No");
              string  confirm = Console.ReadLine().ToLower();
                if (confirm == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("out of the loop");









            Console.ReadLine();
        }
    }
}
