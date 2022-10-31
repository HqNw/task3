using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y:");
            int y = int.Parse(Console.ReadLine());            

            Console.WriteLine("Enter the value of z:");
            int z = int.Parse(Console.ReadLine());

            System.Console.WriteLine((float) ((++x) + (--y)  )/ z);

        }
    }
}