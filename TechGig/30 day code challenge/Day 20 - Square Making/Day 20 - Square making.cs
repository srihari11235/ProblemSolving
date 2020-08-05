using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        
        var output = "*";

        for(int i =0; i < 5 ; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Console.Write(output);

                if( j != 4)
                    Console.Write(" ");
            }

            if(i != 4)
                Console.WriteLine();
        }
    }
}
