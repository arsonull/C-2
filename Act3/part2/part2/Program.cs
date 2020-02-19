using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you want to have a factorial for");
            int x = int.Parse(Console.ReadLine());
            int total = factorial(x);
            Console.WriteLine("{0}! = {1}", x, total);
            Console.ReadKey();
        }

        public static int factorial(int y)
        {
            Console.Out.WriteLine("x is {0}", y);
            if (y == 1)
            {
                return y;
            }
            else
            {
                return y * factorial(y - 1);
            }
        }
    }
}
