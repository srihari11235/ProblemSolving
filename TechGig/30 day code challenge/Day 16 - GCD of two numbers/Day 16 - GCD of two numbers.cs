using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {	
        try
        {
            var code = new CandidateCode();
            var numbers = code.ReadInput();
        
            var gcd = code.GetGCD(numbers[0], numbers[1]);

            Console.Write(gcd);     
        }
        catch(Exception ex)
        {
            Console.Write(ex.ToString());
        }        
    }

    private List<long> ReadInput()
    {
        var input = Console.ReadLine();
        var numbers = new List<long>();
        var characters = input.Split(' ');

        foreach(var character in characters)
        {
            numbers.Add(Int64.Parse(character));
        }

        return numbers;
    }

    private long GetGCD(long numberA, long numberB)
    {
         while (numberA != 0 && numberB != 0)
        {
            if (numberA > numberB)
                numberA %= numberB;
            else
                numberB %= numberA;
        }

        return numberA | numberB;
    }
}
