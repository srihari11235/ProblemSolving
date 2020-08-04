using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        try
        {
            var code = new CandidateCode();
            var sizeOfArray = code.ReadSingleInput();
            var numbers = code.ReadArray();
            var matchingNumber = code.ReadSingleInput();

            // sort the list
            numbers.Sort();
            var iteration = 0;
            var result = "False";

            for(var i=0; i < numbers.Count; i++ )
            {
                for(var j =0; j < numbers.Count; j++)
                {
                    if(i == j)
                        continue;
                    
                    if(numbers[i] + numbers[j] == matchingNumber)
                    {
                        result = "True";
                        break;
                    }
                }
            }
            
            Console.Write(result);

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private int ReadSingleInput()
    {
        var input = Console.ReadLine();

        return Int32.Parse(input);
    }

    private List<int> ReadArray()
    {
        var input = Console.ReadLine();
        var characters = input.Split(' ');
        var numbers = new List<int>();

        foreach(var character in characters)
        {
            numbers.Add(Int32.Parse(character));    
        }

        return numbers;        
    }

}
