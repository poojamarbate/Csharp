using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_OR_compression_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //compression between two values ==,!=,>,<,>=,<=

            int val1 = 10;
            int val2 = 20;
            //bool result = val1 ==val2;
            bool result = val1 != val2;
            Console.WriteLine(result);
            bool greaterthan = val1< val2;
            Console.WriteLine(greaterthan);
            Console.ReadKey();


        }
    }
}
