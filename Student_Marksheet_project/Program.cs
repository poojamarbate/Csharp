using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marksheet_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your roll number:");
            string rollnumber = Console.ReadLine();
            Console.WriteLine("enter your class");
            string std = Console.ReadLine();

            Console.WriteLine("Enter maths marks:");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter science marks:");
            int sci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter english marks:");
            int eng = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter geography marks:");
            int geo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter evs marks:");
            int his = Convert.ToInt32(Console.ReadLine());

            int obt = math + sci + eng + geo + his;
            int per = obt * 100 / 500;

            Console.WriteLine("your name:{0}",name);
            Console.WriteLine("rollnumber:{0}",rollnumber);
            Console.WriteLine("your class:{0}",std);
            Console.WriteLine("Total marks:{0}",obt);
            Console.WriteLine("Your percentage:{0}",per);


            //for Grade
            if (per >= 80)
            {
                Console.WriteLine("Grade:A-1");
            }
           else if (per >= 70)
            {
                Console.WriteLine("Grade:A");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade:B");
            }
           else if (per >= 50)
            {
                Console.WriteLine("Grade:c");
            }
           else if (per >= 45)
            {
                Console.WriteLine("Grade:d");
            }
            else
            {
                Console.WriteLine("Grade:F........fail");
            }


            //if else if -----remark

            if (per >= 80)
            {
                Console.WriteLine("Remark:Excellent");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Remark:very good");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Remark:Good");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Remark:Fair");
            }
            else if (per >= 45)
            {
                Console.WriteLine("Remark:poor....need improvement");
            }
            else
            {
                Console.WriteLine("Bring your parents tommoro!!!!");
            }
           



            //supliement
            int supply = 0;
            if (math<33)
            {
                supply++;
            }
            if (sci < 33)
            {
                supply++;
            }
            if (eng< 33)
            {
                supply++;
            }
            if (geo < 33)
            {
                supply++;
            }
            if (his < 33)
            {
                supply++;
            }

            Console.WriteLine("your are fail in {0} subjects",supply);










            Console.ReadLine();
        }
    }
}
