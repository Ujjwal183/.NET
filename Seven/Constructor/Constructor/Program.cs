using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Example
    {
        //Data Member
        public int x,y;
        
        //1.Default Constructor 
        public Example()
        {
            x = 0;
            y = 0;
            Console.WriteLine("Default Constructor Called");
            Console.WriteLine($"x = {x}, y = {y}");
        }
        
        //2.Parameterized Constructor 
        public Example(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Default Constructor Called");
            Console.WriteLine($"x = {x}, y = {y}");
        }
        
        //3.Copy Constructor 
        public Example(Example obj)
        {
            x = obj.x;
            y = obj.y;
            Console.WriteLine("Default Constructor Called");
            Console.WriteLine($"x = {x}, y = {y}");
        }
        
        //4.Static Constructor 
        static Example()
        {
            Console.WriteLine("Static Constructor Called");
        }
        
        //5.Private Constructor 

        private Example(string message)
        {
            Console.WriteLine("Private constructor in called  : "+message);
        }
        
        //static method to call private Constructor 
        public static void callPrivate()
        {
            Example obj = new Example("Accessed via static method call");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Default constructor
            Example obj1 = new Example();
            // Parameterized constructor
            Example obj2 = new Example(10, 20);
            // Copy constructor
            Example obj3 = new Example(obj2);
            // Calling private constructor indirectly
            Example.callPrivate();

        }
    }
}
