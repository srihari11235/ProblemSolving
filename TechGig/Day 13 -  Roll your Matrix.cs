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

            var result = code.Transpose(matrix);

            code.Print(result);

        }
        catch(Exception ex)
        {
          Console.WriteLine(ex.ToString());
        }
    }

    public Tuple<int, int> GetDimensios()
    {        
        var input = Console.ReadLine();        
        var numbers = GetNumbersFromString(input);

        return new Tuple<int, int>(numbers[0], numbers[1]);
    }

    public List<int> GetNumbersFromString(string input)
    {
        var numbers = new List<int>();        
        var letters = input.Split(' ');
        
        foreach(var letter in letters)
        {
          numbers.Add(Int32.Parse(letter));
        }

        return numbers;
    }

    public int[,] CreateMatrix(Tuple<int, int> dimensions)
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

    public int[,] Transpose(int[,] matrix)
    {
        var numberOfRows = matrix.GetLength(0);
        var numberOfColumns = matrix.GetLength(1);
     
        var result = new int[numberOfColumns, numberOfRows];

        for(var row = 0; row < numberOfRows; row++)
        {
            for(var column = 0; column < numberOfColumns ; column++)
            {
                result[column, row] = matrix[row , column];
            }
        }

        return result;
    }

    public void Print(int[,] matrix)
    {
        for(int row=0 ; row < matrix.GetLength(0); row++)
        {
            for(var column=0; column < matrix.GetLength(1); column++ )
            {
                Console.Write(matrix[row, column]);
                
                if(column + 1 != matrix.GetLength(1))
                    Console.Write(' ');
            }

            if(row + 1 != matrix.GetLength(0))
                Console.WriteLine();
        }
    }
}]