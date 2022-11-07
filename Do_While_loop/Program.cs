using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            smilar to while loop 
            at least once withour the condition being checked.

             
             
             */
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<=10);



            //difference between for & while loop

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
          
            Console.WriteLine("-------------");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("--------------");
            Console.WriteLine(j);

            Console.WriteLine("Loop terminate.....");





            Console.ReadLine();
        }
    }
}
