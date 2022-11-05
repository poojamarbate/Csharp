using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemet_expression_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            //statemets 
            Console.WriteLine("perform addition operation u want to enter two number???");
          

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
           //expression
         
            //operation
            int addition = num1 + num2;
            Console.WriteLine(addition);
            Console.ReadLine();

            if ((num1 >= 0) && (num2 >= 0))
            {
                Console.WriteLine("please enter correct number");
            }


        }

    }
}
