using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c# collection!");

            doStackDemo();
            doListDemo();
        }

        private static void doStackDemo()
        { 
        Console.WriteLine("\nIn doStackDemo");

            Stack<string> stack = new Stack<string>();
            stack.Push("Ankit");
            stack.Push("pagal");
            stack.Push("manoj");
            stack.Push("Sagar");
            stack.Push("Rajesha");
            string pop = stack.Pop();   

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Poped item:" + pop);
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");

            List<string> list = new List<string>();
            list.Add("Ankit");
            list.Add("Rohan");
            list.Add("Boltt");
            list.Add("Ravan");
            list.Add("Dontk");
        

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
