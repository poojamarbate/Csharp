using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int week_day = 2;
            switch (week_day)
            {
                case 1: Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wendesday");
                    break;
                case 4:
                    Console.WriteLine("thusday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default: Console.WriteLine("invalid week");
                    break;
            }
            Console.WriteLine("After switch case");
            Console.ReadLine();
        }
    }
}
