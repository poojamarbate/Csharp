using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "234.23";
            string num2 = "234.23";

            //parse function convert only string data type
            float add = float.Parse(num1) + float.Parse(num2);
            Console.WriteLine("addition ={0}",add);
          
            Console.WriteLine("---------------convert float to  integer data type---------------");
            float val1 = 343.45f;
            float val2 = 34.12f;
            int result = Convert.ToInt32(val1 + val2);
            Console.WriteLine(result);


            Console.ReadLine();

        }
    }
}
