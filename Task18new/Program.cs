using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK18_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "([]{})()";
            Stack<char> bracket = new Stack<char>();
            foreach (var i in str)
            {
                if (i == '(' || i == '[' || i == '{')
                {
                    bracket.Push(i);
                }
                if (i == ')')
                {
                    if (bracket.Contains('('))
                    {
                        bracket.Pop();
                    }
                }
                if (i == ']')
                {
                    if (bracket.Contains('['))
                    {
                        bracket.Pop();
                    }
                }
                if (i == '}')
                {
                    if (bracket.Contains('{'))
                    {
                        bracket.Pop();
                    }
                }
            }
            if (bracket.Count == 0)
            {
                Console.WriteLine("Скобки расставлены корректно!");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не корректно!");
            }
            Console.ReadKey();
        }
    }
}
