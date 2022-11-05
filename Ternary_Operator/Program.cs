using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             boolean expression ? first expression:second expression; ____________________alternate of if_else
             
             
             */

            int a = 20;
            string b = (a > 10) ? "A is greater" : "A is lesser";
            Console.WriteLine(b);
            Console.ReadLine();

        }

    }
}
