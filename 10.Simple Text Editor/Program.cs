using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int CommandsCount = int.Parse(Console.ReadLine());
            string text = "";
            var Stack = new Stack<string>();
            Stack.Push(text);

            for (int i = 0; i < CommandsCount; i++)
            {
                string[] InputCommand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int command = int.Parse(InputCommand[0]);
                if(command==1)
                {
                    text += InputCommand[1];
                    Stack.Push(text);


                }
                else if(command==2)
                {
                    int eraseCount = int.Parse(InputCommand[1]);
                    if (text.Length <= eraseCount)
                        text = "";
                    else
                        text = text.Substring(0, text.Length - eraseCount);
                    Stack.Push(text);

                }
                else if (command==3)
                {
                    int printAtIndex = int.Parse(InputCommand[1]);

                    if (text.Length>=printAtIndex)
                        Console.WriteLine(text[printAtIndex-1].ToString());
                }
                else if(command==4)
                {
                    Stack.Pop();
                    text = Stack.Peek();
                }

            }
        }
    }
}
