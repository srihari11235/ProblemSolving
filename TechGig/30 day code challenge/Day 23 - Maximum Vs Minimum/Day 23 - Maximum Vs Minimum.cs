using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        
        var code = new CandidateCode();

        var numberOfElements = code.ReadNumberOfElments();
        var numbers = code.ReadNumbers();

        numbers.Sort();

        var minNumber = numbers.First();
        var maxNumber = numbers.Last();

        Console.Write(minNumber * maxNumber);

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
}
