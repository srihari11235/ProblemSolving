using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrakets
{
    public class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter the bracket string: " );
            var input = Console.ReadLine();

            var bracket = new Bracket();
           
            if (bracket.ValidateInput(input))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");              
        }       
    }

    public class Bracket
    {
        public bool ValidateInput(string input)
        {
            try
            {
                var stack = new Stack();
                var brackets = SetOpeningAndClosingBrackets();
                var mapping = SetOpenAndCloseMapping();

                foreach (var bracket in input)
                {
                    if (stack.Count == 0)
                    { stack.Push(brackets[bracket]); continue; }

                    var previousBracket = stack.Peek();
                    var currentBracket = brackets[bracket];

                    if (mapping[(Brackets)previousBracket] == currentBracket)
                    { stack.Pop(); continue; }

                    stack.Push(currentBracket);
                }

                if (stack.Count == 0)
                    return true;

                return false;
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException();
            }
        }


        public enum Brackets
        {
            openingSquare,
            closingSquare,
            openingCurly,
            closingCurly,
            openingBraces,
            closingBraces
        }

        public Dictionary<char, Brackets> SetOpeningAndClosingBrackets()
        {
            Dictionary<char, Brackets> brackets = new Dictionary<char, Brackets> {
                { '[', Brackets.openingSquare },
                { ']', Brackets.closingSquare },
                { '{', Brackets.openingCurly  },
                { '}', Brackets.closingCurly  },
                { '(', Brackets.openingBraces },
                { ')', Brackets.closingBraces  }
            };

            return brackets;
        }

        public Dictionary<Brackets, Brackets> SetOpenAndCloseMapping()
        {
            Dictionary<Brackets, Brackets> map = new Dictionary<Brackets, Brackets> {
                { Brackets.openingSquare, Brackets.closingSquare },
                { Brackets.openingCurly, Brackets.closingCurly},
                { Brackets.openingBraces,Brackets.closingBraces},
                { Brackets.closingSquare, Brackets.openingSquare },
                { Brackets.closingCurly, Brackets.openingCurly},
                { Brackets.closingBraces,Brackets.openingBraces}
            };

            return map;
        }
    }
}
