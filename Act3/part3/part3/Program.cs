using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a larger number, and then a smaller number of which you want to know the greatest common divisor.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int answer = gcd(num1, num2);
            Console.Out.WriteLine("The greatest common divisor between {0} and {1} is {2}", num1, num2, answer);
            Console.ReadKey();
        }
        static int gcd(int n1, int n2)
        {
            if(n2 == 0)
            {
                return n1;
            }
            else
            {
                Console.WriteLine("Not yet, the remainder is {0}", n1 % n2);
                return (gcd(n2, n1 % n2));
            }
        }
    }
}
