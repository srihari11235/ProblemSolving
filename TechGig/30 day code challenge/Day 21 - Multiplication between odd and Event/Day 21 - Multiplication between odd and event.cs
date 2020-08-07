using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
	
        try
        {
            var code = new CandidateCode();

            var numberOfElements = code.ReadNumberOfElments();
            var numbers = code.ReadNumbers();
            var sumOfOddNumbers = 0;
            var sumOfEvenNumbers = 0;

            foreach(var number in numbers)
            {
                if(code.IsNumberEven(number))
                    sumOfEvenNumbers += number;
                else
                    sumOfOddNumbers += number;
            }

            Console.Write(sumOfEvenNumbers * sumOfOddNumbers);
        }
        catch(Exception ex)
        {
            Console.Write(ex.ToString());
        }

    }

    private int ReadNumberOfElments()
    {
        var input = Console.ReadLine();

        return Int32.Parse(input);
    }

    private List<int> ReadNumbers()
    {
        var input = Console.ReadLine();
        var characters = input.Split(' ');
        var numbers = new List<int>();

        foreach(var charachter in characters)
        {
            numbers.Add(Int32.Parse(charachter));
        }

        return numbers;
    }

    private bool IsNumberEven(int number)
    {
        return number % 2 == 0;
    }
}
