using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution {
    
    public static void Main(string[] args)
    {
        try
        {
            var run = new Solution();
            var input = Console.ReadLine();
            var numberOfTestCases = Int32.Parse(input);
            
            for(int tcs = 0; tcs < numberOfTestCases; tcs ++)
            {
                var inputDays = Console.ReadLine();
                var numberOfDays = Int32.Parse(inputDays);
                var recordBreakingDays = 0;
                var visitorsInDay = run.GetNumbers();
                var largestNumber = visitorsInDay[0];
                
                for(int i=0; i < numberOfDays; i++)
                {
                    //Number of days is one
                    if(numberOfDays == 1)
                    {
                        recordBreakingDays += 1;
                    }
                    //For the first day
                    else if( i == 0 && 
                        visitorsInDay[i] > visitorsInDay[i + 1])
                    {
                        recordBreakingDays += 1;
                    }
                    //For the last day
                    else if (i == visitorsInDay.Count - 1
                    && visitorsInDay[i] > largestNumber)
                    {
                        recordBreakingDays += 1;
                        largestNumber = visitorsInDay[i];
                    }
                    else if (visitorsInDay[i] > largestNumber )
                    {
                        largestNumber = visitorsInDay[i];
                        
                        if( visitorsInDay[i] > visitorsInDay[i + 1])
                            recordBreakingDays += 1;
                        
                    }
                }
                
                if(tcs == numberOfTestCases - 1)
                    Console.Write("Case #{0}: {1}", tcs + 1, 
                                    recordBreakingDays);
                else
                    Console.WriteLine("Case #{0}: {1}", tcs + 1, 
                                    recordBreakingDays);
            } 
        }
        catch(Exception ex)
        {
            Console.Write(ex.ToString());
        }
    }
    
    public List<int> GetNumbers()
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