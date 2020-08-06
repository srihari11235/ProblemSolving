using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
	
        var code = new CandidateCode();

        var numberOfElements = code.ReadNumberOfElments();
        var numbers = code.ReadNumbers();
        var countOfEvenNumbers = 0;
        var countOfOddNumbers = 0;
        decimal sumOfEvenNumbers = 0;
        decimal sumOfOddNumbers = 0; 
        decimal avgOfEvenNumbers = 0;
        decimal avgOfOddNumbers = 0;

        for(int i=0; i < numbers.Count; i++)
        {
            if(code.IsNumberEven(numbers[i]))
            {
                sumOfEvenNumbers += numbers[i];
                countOfEvenNumbers++;                
            }
            else 
            {
                sumOfOddNumbers += numbers[i];
                countOfOddNumbers++;
            }
        }

        //Codintions for when all numbers are either event or odd
        if(countOfEvenNumbers != 0)
            avgOfEvenNumbers = sumOfEvenNumbers/countOfEvenNumbers;
        if(countOfOddNumbers != 0)    
            avgOfOddNumbers = sumOfOddNumbers/countOfOddNumbers;

        Console.Write(Math.Round(avgOfEvenNumbers, MidpointRounding.AwayFromZero) + Math.Round(avgOfOddNumbers, MidpointRounding.AwayFromZero));
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
