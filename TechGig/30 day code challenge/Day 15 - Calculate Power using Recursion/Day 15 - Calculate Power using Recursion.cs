
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
	
        var code = new CandidateCode();

        var numbers = code.GetInput();

        var number = numbers.Item1;
        var power = numbers.Item2;

        var result = code.CalculatePower(number, power);

        Console.Write(result);

    }

    private Tuple<int, int> GetInput(){

        var numbers = new List<int>();
        var input = Console.ReadLine();
        var characters = input.Split(' ');

        foreach(var charachter in characters)
        {
            var number = Int32.Parse(charachter);

            numbers.Add(number);            
        }

        return new Tuple<int, int>(numbers[0], numbers[1]);
    }

    private int CalculatePower(int number, int power)
    {
        if(power == 0)
            return 1;
        
        return number * CalculatePower(number, power -1);
    }
}
 


