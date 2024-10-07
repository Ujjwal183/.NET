using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            int [] numbers = new int [3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Maximum Number : "+numbers.Max());
        }
    }
}
