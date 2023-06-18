using System;
using System.Collections.Generic;

namespace Stack_of_Strings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty()) ;
            stack.AddRange(new List<string>()
            {
                "12",
                "312",
                "211",
                "gosho"
            });
            foreach (string arg in stack) {
                Console.WriteLine(arg);
            }
        }
    }
}
