using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatinate_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {{1,2,3},{4,5,6}};
            int[,] matrix2 = { {7,8,9},{10,11,12}};
            int[,] concatinated = new int[2, 6];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    concatinated[i,j]= matrix1[i,j];
                    concatinated[i,j+3]= matrix2[i,j];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    Console.WriteLine(concatinated[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
