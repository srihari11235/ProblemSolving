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
            var sumOfDiagonal1 = 0;
            var sumOfDiagonal2 = 0;

            for(int n = 0; n < numberOfRows; n++)
            {
                for(int m = 0; m < numberOfColumns; m++)
                {
                    if(n == m)
                        sumOfDiagonal1 += matrix[n,m];
                    
                    if( ((numberOfColumns-1) - n) == m)
                        sumOfDiagonal2 += matrix[n,m];
                }
            }

            if(sumOfDiagonal1 > sumOfDiagonal2)
                Console.Write("Diagonal 1");
            else if(sumOfDiagonal2 > sumOfDiagonal1)
                Console.Write("Diagonal 2");
            else
                Console.Write("Equal");

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
