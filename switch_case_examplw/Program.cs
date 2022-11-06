using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_example
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("do you want ice-cream ? if yes press '1' OR if NO press '0' .");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: Console.WriteLine("Welcome ......do u want which flavor of ice-cream ?");
                    Console.WriteLine("enter your flavor");
                    string flavor=Console.ReadLine();
                    switch (flavor)
                    {
                        case "Vanilla":
                            Console.WriteLine("flavor: Vanilla Ice Creamn");
                            break;

                        case "Chocolate":
                            Console.WriteLine("flavor:Chocolate Ice Cream");
                            break;
                        case "Strawberry":
                            Console.WriteLine("flavor:Strawberry Ice Cream");
                            break;
                        default:
                            Console.WriteLine("flavor is not avalible");
                            break;

                    }
                    break;
                case 0: Console.WriteLine("No issue......");
                    break;
                default: Console.WriteLine("please rate our service.....hope u like our ice-cream flavor");
                    break;
            }
            Console.WriteLine("BYE BYE.........");
            Console.ReadLine();
        }
    }
}
