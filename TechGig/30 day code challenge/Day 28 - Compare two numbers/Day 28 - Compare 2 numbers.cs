using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        
        var code = new CandidateCode();
        var numbers = code.ReadNumbers();
        var numberA = numbers.Item1;
        var numberB = numbers.Item2;
        var sumOfNumberA = 0;
        var sumOfNumberB = 0;

       // Console.WriteLine(numberA);
       // Console.WriteLine(numberB);
        while(numberA != 0 || numberB != 0)
        {
            if(numberA != 0)
            {
                var digitA = code.GetNextDigit(numberA);
                
                sumOfNumberA += digitA;
                
                numberA = numberA / 10;

            }

            if(numberB != 0)
            {
                var digitB = code.GetNextDigit(numberB);
                
                sumOfNumberB += digitB;
                
                numberB = numberB/ 10;
            }
       }

        if(sumOfNumberA == sumOfNumberB)
            Console.Write("Equal");
        else if(sumOfNumberA > sumOfNumberB)
            Console.Write(numbers.Item1);
        else
            Console.Write(numbers.Item2);

    }
    private Tuple<int, int> ReadNumbers()
    {
        var input = Console.ReadLine();
        var numberString = "";
        var numbers = new List<int>();

        //Special logic added to handle multiple spaces between numbers input
        foreach(var character in input)
        {
           if(Char.IsDigit(character))
           {
                numberString = numberString + character;                
           }
           else
           {              
               int number;            
               if(Int32.TryParse(numberString, out number))
                    numbers.Add(number);                
                numberString = "";
           }            
        }

        int num;
        if(Int32.TryParse(numberString, out num))
            numbers.Add(num);

        return new Tuple<int, int>(numbers[0], numbers[1]);
    }

    private int GetNextDigit(int number)
    {
        return number % 10;
    }
}
