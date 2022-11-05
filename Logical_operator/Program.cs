using System;

namespace Logical_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
              Logical OR conditional Operators
              AND (&&)
              OR  (||)


             */

            int a = 40;
            int b = 30;
            int d = 10;
            // bool c = (a > b) && (b < a)&&(a<d);


            bool c = (a > b) || (b < a) || (a < d);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
