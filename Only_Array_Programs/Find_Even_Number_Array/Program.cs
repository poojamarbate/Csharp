using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Even_Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many number u want to store in array");
            int num = int.Parse(Console.ReadLine());
            int[] my_array = new int[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter data:");
                int data = int.Parse(Console.ReadLine());
                my_array[i] = data;
            }
            Console.WriteLine("Your data ................");
            foreach (int item in my_array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n--------------------Even number------------------");
            foreach (int item in my_array)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
