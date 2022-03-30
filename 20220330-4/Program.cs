using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220330_4
{
    internal class Program
    {
        private static int fib(int n)
        { 
            if (n < 2)
                return 1;
            else
                return fib(n-1) + fib(n-2);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(fib(i));
            Console.WriteLine(fib(10));
            Console.ReadLine();
        }
    }
}
