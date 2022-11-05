using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percedence_Of_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             operators in c# have certain associated proiority levels
             
            8/2-3+2*2
             BODMAS(Bracket,of ,Division,multi,add,sub)
             */

            int a = 8 / 2 - 3 + 2 * 2;
            Console.WriteLine(a);
            Console.ReadLine();


        }
    }
}
