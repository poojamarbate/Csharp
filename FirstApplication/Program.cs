using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("your name:"+name);
           
           
                    int age;
                    Console.WriteLine("enter your age");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Age:"+age);



                        if (age > 0) 
                        {
                            Console.WriteLine("name: "+name+" age: "+age+"\n\n\n welcome to quize game");

                Console.WriteLine("first question is.....\n");
                             

                        }
            else
            {
                Console.WriteLine("enter correct age ");
            }
            Console.ReadLine();
        }
    }
}
