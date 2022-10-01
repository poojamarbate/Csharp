using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading and writing from user input
            Console.Write("Enter your name: ");

            string name= Console.ReadLine();
            //   Console.Write("your name: "+name); //concatention syntax

            Console.WriteLine("your name is :{0}",name);  //placeholder syntax
            Console.ReadLine();   
        }
    }
}
