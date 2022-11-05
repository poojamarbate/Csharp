using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_in_csharp
{
    class Program
    {
        public const double Pi = 3.14;
        public const string company_name = "ABC COMPANY";
        static void Main(string[] args)
        {
            
            Console.WriteLine(Pi );
            Console.WriteLine(company_name);
            Console.ReadLine();
        }
    }
}
