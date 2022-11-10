using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initizing_array_with_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many number of items u want to store in array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Data:");
                int data = int.Parse(Console.ReadLine());
                number[i] = data;
            }
            Console.WriteLine("----------------your data---------------");
            foreach (int item in number)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
