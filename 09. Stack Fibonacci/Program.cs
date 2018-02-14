using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            if (input == 0)
            {
                Console.WriteLine(0);
                return;
            }
            long first = 0;
            long second = 1;
            long third = 1;
            var stack = new Stack<long>();

            for (int i = 0; i < input-2; i++)
            {
                long copy = first + second;
                first = second;
                second = third;
                third = first + second;
            }
            Console.WriteLine(third);

        }
    }
}
