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
            var result = "True";

            numbers.Sort();
            
            for(int i = 0; i < numbers.Count; i++)
            {
                if(i == 0 )
                    continue;
                
                if(numbers[i] >= 0 && (numbers[i] - numbers[i-1] != 1))
                {
                    result = "False"; 
                    break; 
                }
                else if(numbers[i] < 0 && (numbers[i] - numbers[i - 1] != 1))         
                {
                    result = "False"; 
                    break; 
                }
            }

            Console.Write(result);
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
}
