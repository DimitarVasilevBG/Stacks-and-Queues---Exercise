using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long S = input;
            int counter = 1;
            
            var Que = new Queue<long>();
            Console.Write(input + " ");

            for (int i = 0; i < 49; i++)
            {

                if (counter == 1)
                {
                    long expression = S + 1;
                    Que.Enqueue(expression);
                    Console.Write(expression + " ");
                    counter++;
                    continue;
                }
                else if (counter == 2)
                {
                    long expression = (2 * S) + 1;
                    Que.Enqueue(expression);
                    Console.Write(expression + " ");
                    counter++;
                    continue;
                }
                else if (counter == 3)
                {
                    long expression = S + 2;
                    Que.Enqueue(expression);
                    Console.Write(expression + " ");
                    counter++;
                    if(Que.Count>0)
                    S = Que.Dequeue();
                    counter = 1;
                }


            }
        }
    }
}
