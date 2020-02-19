using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer and I will show how to make it into a 1 with division and addition");
            int num = int.Parse(Console.ReadLine());
            int x = getToOne(num);
            Console.WriteLine("Your number is now: " + x);
            Console.ReadKey();
        }

        public static int getToOne(int n)
        {
            Console.Out.WriteLine("N is " + n);
            if (n==1)
            {
                return n;
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.Out.WriteLine("N is even, dividing by 2");
                    return getToOne(n / 2);
                }
                else
                {
                    Console.Out.WriteLine("N is odd, adding 1");
                    return getToOne(n + 1);
                }
            }
        }
    }
}
