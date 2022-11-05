using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_variable
{
    class Program
    {
        public const string companyname = "ABC company";
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("your name:"+name+" company name :"+companyname);
            Console.ReadKey();

        }
    }
}
