using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        
        var code = new CandidateCode();

        var number = code.ReadNumber();
        var sumOfOddNumber = 0;
        var sumOfEvenNumber = 0;

        while(number != 0)
        {
            var digit = code.GetNextDigit(number);

            if(code.IsDigitEven(digit))
                sumOfEvenNumber += digit;
            else
                sumOfOddNumber += digit;
            
            number = number /10;
        }

        if(sumOfEvenNumber > sumOfOddNumber)
            Console.Write(sumOfEvenNumber - sumOfOddNumber);
        else
            Console.Write(sumOfOddNumber - sumOfEvenNumber);
    }


    private int ReadNumber()
    {
        var input = Console.ReadLine();

        return Int32.Parse(input);
    }

    private bool IsDigitEven(int digit)
    {
        return digit % 2 == 0;
    }

    private int GetNextDigit(int number)
    {
        return number % 10;
    }
}
