using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Of_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Operators: its a symbols which are used for different
                        operations like mathematical expresssions 
                        function call etc.

            Types of Operators

            1)Assignment Opertaors ---> '='
            2)Arithmatic Operatos ----> ' +,-,*,/,%'
            3)Conditional ------------> ?,&&,||,??
            4)Unary ------------------> +var,-var,!var,~var
            5)Increment & decrement ---> ++var ,--var
            6)Relational --------------> '<,>,>=,<=,==,!='
            7)Logical ------------------>&,^,|


             */

            int a;
            a = 20; //assigment operations
            Console.WriteLine(a);
           


            //Arithmatic Operators
            //int val1, val2, add;
            //Console.WriteLine("Enter first value:");
            //val1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second value:");
            //val2 = int.Parse(Console.ReadLine());

            ////addition
            //add = val1 + val2;
            //Console.WriteLine("Addition:{0}",add);

            ////subtraction
            //int sub = val1 - val2;
            //Console.WriteLine(sub);

            ////multiplication
            //int mul = val1 * val2;
            //Console.WriteLine(mul);

            ////division
            //int div = val1 / val2;
            //Console.WriteLine(div);

            ////modulus
            //int mod = val1 % val2;
            //Console.WriteLine(mod);






            //conditional
            /* if ___else
         
            synatx: condition ? first_expression : second_expression ;
             
             
             */

            int x = 5, y = 10, result;
            result = x > y ? x : y;
            Console.WriteLine("result:{0}",result);

         //which value is greater

            result = x < y ? x : y;
            Console.WriteLine("result:{0}",result);






            //Unary Operator
            /* increment,decrement
            
             post increment
             pre increment

             */

            int num = 10, res;

            //post increment
            //res =10 -----after update 11

            res = num++; //become 11 now
            Console.WriteLine(num);

            res = num--;//10
            Console.WriteLine(num);



            //pre increment example
            res = ++num;
            Console.WriteLine(num);
            res = --num;
            Console.WriteLine(num);






            
            Console.ReadKey();
        }
    }
}
