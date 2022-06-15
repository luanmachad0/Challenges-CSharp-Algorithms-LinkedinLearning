using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class Program
    {

        static String ReverseEachWord(String input) {
           if (string.IsNullOrEmpty(input))
                return input;

           var stringSplited = input.Split(" ");
           var reversed = "";

           foreach(var word in stringSplited)
           {
                if (word == stringSplited.Last())
                    reversed = reversed + Reverse(word);
                else
                    reversed = (reversed + Reverse(word) + " ");
           }
           
            return reversed;
        }

        static String Reverse(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args) {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}