using System;
using System.Collections.Generic;

namespace Queue___Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var run = new Program();

            var result = run.ReverseStringForTheGivenNumberOfTimes(5, "Learning Queue Functions");

            //Print the reversed string
            foreach (char letter in result)
            {
                Console.Write(letter);
            }
        }

        private Queue<char> ReverseStringForTheGivenNumberOfTimes(int n, string word)
        {
            var letterQueue = new Queue<char>();
            
            foreach(var letter in word)
            {
                letterQueue.Enqueue(letter);
            }

            for(var i =0; i<n; i++)
            {
                if (letterQueue.Count == 0)
                    break;

                var ch = letterQueue.Peek();

                letterQueue.Dequeue();
                letterQueue.Enqueue(ch);
            }

            return letterQueue;
        }
    }
}
