using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Stack<char> reversed= new Stack<char>();
            for (int i = 0; i < line.Length; i++)
            {
                reversed.Push(line[i]);
            }
            foreach (var ch in reversed)
            {
                Console.Write(ch);
            }
        }
    }
}
