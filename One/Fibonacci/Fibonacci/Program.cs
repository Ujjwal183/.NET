using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initial = 0, final = 1;
            int sum = 0;
            Console.Write("Enter size of the fibonacci sequence: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Fibonaci : " + initial + " " + final + " ");
            for (int i = 2; i < size; i++)
            {
                sum = initial + final;
                Console.Write("{0} ", sum);
                initial = final;
                final = sum;
            }
        }
    }
}
