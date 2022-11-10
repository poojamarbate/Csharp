using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Types of array
             -single dimensional
            data stored in single row



             -multi dimensional
             it store single dimensional data in two or more dimensional.



             
             
             
             
             
             */
            //int[] myarray = new int[3];
            //myarray[0] = 11;
            //myarray[1] =22;
            //myarray[2] = 33;
            //foreach (int m in myarray)
            //{
            //    Console.WriteLine(m);
            //}

            //int i, j;
            //int[,] myarray = new int[3, 4] {
            //    {12,44,45,67 },
            //    {13,24,35,57 },
            //    { 76,88,99,45}
            //};//first diem_rows,second dim_cloumns


            //-------------------------------------------------
            //for (i = 0; i <myarray.GetLength(0); i++)
            //{
            //    for (j = 0; j < myarray.GetLength(1); j++)
            //    {
            //        Console.Write(myarray[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            //---------------------------------------------------
            //foreach (int item in myarray)
            //{
            //    Console.WriteLine(item);
            //}




            //-------------------JAGGED ARRAY
            int[][] number = new int[3][];
            number[0] = new[] { 1, 2, 3, 4, 5 };
            number[1] = new[] { 1, 2, 3};
            number[2] = new[] { 1, 2};

            //for(int i = 0; i < number.GetLength(0); i++)
            //{
            //    for(int j=0;j<number[i].Length;j++)
            //    {
            //        Console.Write(number[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            foreach (int[] item in number)
            {
                foreach (int i in item)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
