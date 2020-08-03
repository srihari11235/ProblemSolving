using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
	 
     try
     {
         var code = new CandidateCode();
         var matrixADimensions = code.GetDimensios();
         var matrixA = code.CreateMatrix(matrixADimensions);

         var matrixBDimensions = code.GetDimensios();
         var matrixB = code.CreateMatrix(matrixBDimensions);

         var result = code.AddTwoMatrices(matrixA, matrixB);

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

    public int[,] AddTwoMatrices(int[,] matrixA, int[,] matrixB)
    {
        if(matrixA.GetLength(0) != matrixB.GetLength(0))
            throw new ArgumentException();

        if(matrixA.GetLength(1) != matrixB.GetLength(1))
            throw new ArgumentException();

        var result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for(int row=0 ; row < matrixA.GetLength(0); row++)
        {
            for(var column=0; column < matrixA.GetLength(1); column++ )
            {
               result[row,column] = matrixA[row, column] + matrixB[row,column];
            }
        }   

        return result;
    }
}
