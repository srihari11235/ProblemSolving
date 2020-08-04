using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
     try
     {   
        var code = new CandidateCode();

        var lengthOfArray = code.ReadLengthOfArray();
        var unSortedNumbers = code.ReadNumbers();
        var numbersOutOfSync = -1;
        var finalResult = new List<int>();        
        var result = new List<int>();      
        var outOfSyncNumbers = new List<int>();    
        var previousNumberToCheck = -1;
        var updatePreviousNumber = true; 

        for(int i = 1; i < lengthOfArray; i++)
        {
            var subResult = new List<int>();
            
            if(updatePreviousNumber)
                previousNumberToCheck = unSortedNumbers[i - 1];

            if((unSortedNumbers[i] > previousNumberToCheck ))                                                                          
            {   
                updatePreviousNumber = true; 
                continue;
            }
            else
                updatePreviousNumber = false;
            
            for(int j = 0; j <= i; j++)
            {                                       
                if(unSortedNumbers[j] < unSortedNumbers[i])
                    continue;
                                    
               subResult.Add(unSortedNumbers[j]);                     
            }                                    

            if(!finalResult.Any())                        
                finalResult = subResult;            
            else                           
                finalResult = finalResult.Union(subResult).ToList();                                     
        }   

        var resultString = "";
        
        for(int i = 0; i < lengthOfArray; i++)
        {
            if(finalResult.Any(x => x.Equals(unSortedNumbers[i])))
            { 
                resultString +=  unSortedNumbers[i].ToString() + ' ';
            }
        }

        Console.Write(resultString.Trim());
     }   
     catch(Exception ex)
     {
         Console.WriteLine(ex.ToString());
     }        
    }

    private int ReadLengthOfArray()
    {
        var input = Console.ReadLine();

        return Int32.Parse(input);
    }

    private int[] ReadNumbers(){
        var input = Console.ReadLine();
        var charachters = input.Split(' ');
        var unsoretedNumbers = new int[charachters.Length];
        for(var i = 0; i < charachters.Length; i ++)
        {
            unsoretedNumbers[i] = Int32.Parse(charachters[i]);
        }

        return unsoretedNumbers;
    }
}
