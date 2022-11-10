using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Odd_Number_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 12,3,6,14,16,19,17,10};
            Console.WriteLine("\nAll number");
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine("\n\nOdd number");
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0) { 
                Console.WriteLine(number[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
