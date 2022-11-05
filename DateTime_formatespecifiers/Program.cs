using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_formatespecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("{0:D}",dt);
            Console.WriteLine("{0:f}",dt);
            Console.ReadLine();
        }
    }
}
