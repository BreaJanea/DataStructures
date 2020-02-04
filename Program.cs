using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static Stack<char> stack = new Stack<char>();
        static char[] arr;
        static void Main(string[] args)
        {
            Console.Write("Please enter a word you would like to reverse: ");
            string input = Console.ReadLine();

            Console.WriteLine("This is your reverse: " + Reverse(input));
        }

        static string Reverse(string str)
        {
             arr = str.ToCharArray();
             string reverseWord = null;

            for (int i = 0; i < arr.Length; i++)
            {
              stack.Push(arr[i]);
            }

            while (stack.Count > 0)
            {
               reverseWord += stack.Pop();       
            }
            return reverseWord;
        }   
    }   
}