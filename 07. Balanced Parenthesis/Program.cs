using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] brackets = new char[] { '(', '{', '[' ,};
            char[] brackets2 = new char[] { ')', '}', ']' ,};
            var Stack = new Stack<char>();
            var Que = new Queue<char>();
            if (input.Length % 2 != 0 || input.Length==0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (brackets.Contains(input[i]))
                    Stack.Push(input[i]);
                else if (brackets2.Contains(input[i]))
                {
                    char EndBracket = input[i];
                    char OpenBracket = Stack.Pop();
                    if (EndBracket == ')')
                    {
                        if (OpenBracket != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (EndBracket == ']')
                    {
                        if (OpenBracket != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (EndBracket == '}')
                    {
                        if (OpenBracket != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }

                }
                
            }
            Console.WriteLine("YES");
        }
    }
}
