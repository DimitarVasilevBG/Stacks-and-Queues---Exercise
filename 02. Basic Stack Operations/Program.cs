using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            long PushCount = commands[0];
            long PopCount = commands[1];
            long SpecialNumber = commands[2];
            long[] NumbersToPush = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();


            var Stack = new Stack<long>(NumbersToPush);
            for (int i = 0; i < PopCount; i++)
            {
                if(Stack.Count>0)
                {
                    Stack.Pop();
                }
            }
            if(Stack.Contains(SpecialNumber))
                Console.WriteLine("true");
            else if(Stack.Count==0)
                Console.WriteLine("0");
            else
                Console.WriteLine(Stack.Min());

        }
    }
}
