using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Statments
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             types of jump statment
            break
            continue
            goto
            return
             
             
             
             
             */
            for(int i = 1; i < 10; i++)
            {
               //print odd number
                //if (i%2==0)
                    if (i== 5)
                    {
                    goto stop;
                     //break;
                    //continue; //current iteration skip and print after iteration
                    }
                Console.WriteLine(i);
            }

            Console.WriteLine("Loop terminate");
        stop: 
            Console.WriteLine("program exist..");
            Console.ReadLine();
        }
    }
}
