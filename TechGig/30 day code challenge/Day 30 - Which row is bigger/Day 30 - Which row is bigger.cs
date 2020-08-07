using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        try
        {
            var code = new CandidateCode();
            var dimensions = code.GetDimensios();
            var matrix = code.CreateMatrix(dimensions);
            var numberOfRows = matrix.GetLength(0);
            var numberOfColumns = matrix.GetLength(1);
            var sumOfRowWithMax = 0;            
            var result = "";
            var isSumEqual = false;

            for(int i =0; i < numberOfRows; i++)
            {
                var sumOfRow = 0;

                for(int j =0; j < numberOfColumns; j++)
                {
                    sumOfRow += matrix[i ,j];
                }

                if(sumOfRowWithMax < sumOfRow)
                { 
                    sumOfRowWithMax = sumOfRow;
                    result = string.Format("Row {0}", i + 1);
                    isSumEqual = false;
                }
                else if(sumOfRowWithMax == sumOfRow)                
                {
                    isSumEqual = true;             
                }
            }

         if(isSumEqual)
            Console.Write("Equal");
         else
            Console.Write(result);
        
        }
        catch(Exception ex)
        {
            Console.Write(ex.ToString());
        }
    }

      private Tuple<int, int> GetDimensios()
    {        
        var input = Console.ReadLine();        
        var numbers = GetNumbersFromString(input);

        return new Tuple<int, int>(numbers[0], numbers[1]);
    }

    private List<int> GetNumbersFromString(string input)
    {
        var numbers = new List<int>();        
        var letters = input.Split(' ');
        
        foreach(var letter in letters)
        {
        numbers.Add(Int32.Parse(letter));
        }

        return numbers;
    }

    private int[,] CreateMatrix(Tuple<int, int> dimensions)
    {
        var matrix = new int[dimensions.Item1, dimensions.Item2]; 

        for(int row=0 ; row < dimensions.Item1; row++)
        {
            var input = Console.ReadLine();
            var numbers = GetNumbersFromString(input);

            for(var column=0; column < numbers.Count(); column++ )
            {
                matrix[row, column] = numbers[column];
            }
        }

        return matrix;
    }
}
