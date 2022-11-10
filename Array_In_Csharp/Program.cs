using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_In_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Array:array is a collection of elements of a single data
                    type stored in adjacent memory locations.
             
             -stored single data type
            -each value is referred to as a elements
             
             
             
             
             
             
             
             
             
             */
            string[] colour = { "blue", "white", "pink" };//type1
            string[] names = new string[] {"Pooja","Rani","Golu","jiya" };//type2
            int [] number = new int[3];//type
            number[0] = 10;
            number[1] = 22;
            number[2] = 45;
            foreach (string c in colour)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
