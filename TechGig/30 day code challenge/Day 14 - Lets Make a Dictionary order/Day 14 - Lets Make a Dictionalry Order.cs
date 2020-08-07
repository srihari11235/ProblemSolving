using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        
        try
        {
            var code = new CandidateCode();     
            var numberOfWords = code.ReadNumberOfWords();
            var words = new List<string>();

            for(var count = 0; count < numberOfWords; count++)
            {
            var word = Console.ReadLine();
            words.Add(word);      
            }

            words.Sort();
            
            code.Print(words);
        }
        catch(Exception ex)
        {
            Console.Write(ex.ToString());
        }
    }

    private int ReadNumberOfWords()
    {
        var input = Console.ReadLine();

        return Int32.Parse(input);
    }

    private void Print(List<string> words)
    {
        for(int count=0; count < words.Count; count++)
        {
            Console.Write(words[count]);

            if(count + 1 != words.Count)
                Console.WriteLine();
        }
    }
}
