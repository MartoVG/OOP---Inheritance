using System;
using System.Collections.Generic;

namespace Random_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("pesho");
            list.Add("Oop");
            list.Add("Tosho");
            list.Add("Tanq");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}
