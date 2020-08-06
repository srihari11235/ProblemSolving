using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
	
        var code = new CandidateCode();

        var number = code.ReadNumber();
        var biggestNumber = 0;

        while(number != 0)
        {
            var digit = number % 10;

            if(digit > biggestNumber)
                biggestNumber = digit;

            number = number/10;
        }

        Console.Write(biggestNumber);
    }


    private int ReadNumber()
    {
        var input = Console.ReadLine();

        return Int32.Parse(input);
    }
}
