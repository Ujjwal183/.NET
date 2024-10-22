using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a 2x3 array
            int[,] matrix = new int[2,3];

            // input
            Console.WriteLine("Enter 2x3 Array :");
            for(int i = 0;i<2;++i)
            {
                for(int j = 0 ; j<3 ;++j)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //print
            for(int i = 0;i<2;++i)
            {
                for(int j = 0 ; j<3 ;++j)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
