using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(numbers);

            while (stack.Count>0)
            {
                Console.Write(stack.Pop()+" ");
            }


        }
    }
}
