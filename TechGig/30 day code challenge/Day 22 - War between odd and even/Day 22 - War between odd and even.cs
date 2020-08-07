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

            for(int i = 0; i < numbers.Count; i++)
            {
                    if(i == 0)                            
                        sumOfEvenNumbers += numbers[i];                           
                    else if(i == 1)                            
                        sumOfOddNumbers += numbers[i];                                      
                    else if(code.IsIndexEven(i))                            
                        sumOfEvenNumbers += numbers[i];                            
                    else                            
                        sumOfOddNumbers += numbers[i];                            
            }

            if(sumOfEvenNumbers < sumOfOddNumbers)
                Console.Write(sumOfOddNumbers - sumOfEvenNumbers);
            else
                Console.Write(sumOfEvenNumbers - sumOfOddNumbers);  
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

    private bool IsIndexEven(int number)
    {
        return number % 2 == 0;
    }
}
