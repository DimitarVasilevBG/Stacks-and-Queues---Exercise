using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int CommandCount = int.Parse(Console.ReadLine());
            var InputStack = new Stack<int>();
            var MaxNumberStack = new Stack<int>();
            MaxNumberStack.Push(0);

            for (int i = 0; i < CommandCount; i++)
            {
                int[] CommandInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int Command = CommandInput[0];
                if (Command == 1)
                {
                    int NumberToPuSh = CommandInput[1];
                    InputStack.Push(NumberToPuSh);
                    if (NumberToPuSh > MaxNumberStack.Peek())
                    {
                        MaxNumberStack.Push(NumberToPuSh);
                    }

                }
                else if (Command == 2)
                {
                    int RemovedNumber;
                    if (InputStack.Count > 0)
                    {

                        RemovedNumber = InputStack.Pop();
                        if (MaxNumberStack.Peek() == RemovedNumber)
                            MaxNumberStack.Pop();

                    }
                }
                else if(Command == 3)
                    Console.WriteLine(MaxNumberStack.Peek());
                
            }
            
        }
    }
}
