using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSpanProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var prices = new List<int> { 100, 80, 60, 70, 60, 75, 85 };

            var run = new Program();

            var result = run.CalculateSpan(prices);            

            while (result.Count != 0)
            {
                Console.WriteLine(result.Pop().ToString());
            }
        }


        public Stack CalculateSpan(List<int> prices)
        {
            var stack1 = new Stack();
            var stack2 = new Stack();
            var result = new Stack();

            foreach (var price in prices)
            {
                int count = 0;

                while (stack1.Count != 0 && price > (int)stack1.Peek())
                {
                    var poped = stack1.Pop();
                    stack2.Push(poped);
                }

                while (stack2.Count != 0)
                {
                    if (count == 0)
                        stack1.Push(price);

                    stack1.Push(stack2.Pop());
                    count++;
                }

                if (stack1.Count != 0 && price <= (int)stack1.Peek())
                    stack1.Push(price);               

                if (stack1.Count == 0)
                    stack1.Push(price); 

                result.Push(count + 1);
            }

            return result;
        }
    }
}
