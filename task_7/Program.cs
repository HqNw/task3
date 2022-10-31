using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x:");
            uint x = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y:");
            uint y = uint.Parse(Console.ReadLine());            

            Console.WriteLine("Enter the value of z:");
            uint z = uint.Parse(Console.ReadLine());

            System.Console.WriteLine((x + y)*z);

        }
    }
}