using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatinateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[]{1,2,3};
            int[] Array2 = new int[]{4,5,6};
            int[] Array3 = Array1.Concat(Array2).ToArray();
            
            
            Console.WriteLine(string.Join(",", Array3));
        }
    }
}

